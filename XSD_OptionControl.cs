using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XSD_Tool_Helper
{
    public partial class XSD_OptionControl : UserControl
    {
        public XSD_OptionControl()
        {
            InitializeComponent();
        }

        public List<string> ElementList { get; set; } = new List<string>();
        private List<FileInfo> FileList { get; set; }

        public IMasterControl ParentControl { get; set; }

        private void btn_ClearSelected_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(this, "Delete selectecd Elements from the listbox?", "Are you sure?", MessageBoxButtons.YesNo);
            if (ask == DialogResult.No)
                return;
            foreach (string str in this.listBox_Elements.SelectedItems)
                ElementList.Remove(str);
            this.listBox_Elements.Items.Clear();
            foreach (string str in ElementList)
                this.listBox_Elements.Items.Add(str);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(this, "Delete all Elements from the listbox?", "Are you sure?", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                this.listBox_Elements.Items.Clear();
                this.ElementList.Clear();
            }
        }

        private void listBox_Elements_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Delete)
                this.btn_ClearSelected.PerformClick();
        }

        private void txt_Element_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                this.btn_AddElement.PerformClick();
        }

        private void btn_AddElement_Click(object sender, EventArgs e)
        {
            string str = this.txt_Element.Text;
            this.txt_Element.Text = "";
            if (!String.IsNullOrWhiteSpace(str) && !this.ElementList.Contains(str))
            {
                this.listBox_Elements.Items.Add(str);
                this.ElementList.Add(str);
            }
        }

        private void radio_DataSetClass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radio_DataSetClass.Checked)
            {
                //this.chk_LinqDataSet.Checked = true;
                this.chk_LinqDataSet.Enabled = false;
            }
            else
            {
                this.chk_LinqDataSet.Enabled = true;
            }
        }

        private void XSD_OptionControl_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = XSD_Options.SupportedLanguages_ComboxItems;
            this.comboBox1.SelectedIndex = 0;
            this.radio_SerialClass.Checked = true;
        }

        private void btn_LoadConfig_Click(object sender, EventArgs e)
        {

        }

        public void Run() { }

        public string[] GenerateCommand(List<FileInfo> FileListToConvert, string DestinationFolder)
        {
            this.FileList = new();
            foreach (FileInfo f in FileListToConvert)
            {
                string path = Path.Combine(DestinationFolder, Path.ChangeExtension(f.Name, ".XSD"));
                FileList.Add(new FileInfo(path));
            }
            return GenerateCommand(false);
        }

        public void LoadParamFile() 
        {
            this.chk_DataBinding.Checked = false;
            this.chk_Fields.Checked = false;
            this.chk_LinqDataSet.Checked = false;
            this.chk_Order.Checked = false;
            this.chk_SuppressBanner.Checked = false;
            this.txt_URI.Text = "";
            this.radio_SerialClass.Checked = false;
            this.radio_DataSetClass.Checked = !this.radio_SerialClass.Checked;
            this.comboBox1.SelectedItem = "CS";
            
            this.listBox_Elements.Items.Clear();
        }

        public void GenerateParamFile() { }

        public string[] GenerateCommand(bool UseParentControlFileList = true)
        {
            List<string> ret = new();
            //Setup the XMLProc object
            XSD_Options builder = new XSD_Options();

            builder.ElementList.AddRange(this.ElementList);
            builder.EnableDataBinding = this.chk_DataBinding.Checked;
            builder.EnableLinqDataSet = this.chk_LinqDataSet.Checked;
            builder.GenerateFieldsInsteadOfProperties = this.chk_Fields.Checked;
            builder.Language = XSD.LangaugeCmbToEnum(this.comboBox1.SelectedIndex);
            builder.Order = this.chk_Order.Checked;
            builder.SuppressBanner = this.chk_SuppressBanner.Checked;
            builder.URI = this.txt_URI.Text;
            builder.WhatToGenerate = (!this.Enabled) ? XSD_Options.Generate.NOTHING : (this.radio_SerialClass.Checked) ? XSD_Options.Generate.CLASSES : XSD_Options.Generate.DATASET;

            //Items from parent control
            builder.ParameterFileContainsInputFiles = ParentControl.ParamFileContainsFilePaths;
            builder.NameSpace = ParentControl.NameSpace;
            builder.OutputDirectory = ParentControl.OutputFolder?.FullName;
            builder.GenerateParameterFile = ParentControl.GenerateParamFile;

            if (UseParentControlFileList)
            {
                //Ensure all files are of XSD file extension
                FileList = new();
                foreach (FileInfo file in ParentControl.InputFileList)
                {
                    FileList.Add(new FileInfo(Path.ChangeExtension(file.FullName, ".XSD")));
                }
            }

            if (ParentControl.ProcessIndividually)
            {
                foreach (FileInfo file in FileList)
                {
                    builder.InputFilePaths.Clear();
                    builder.InputFilePaths.Add(file);
                    ret.Add(builder.GenerateCommand());
                }
            }
            else
            {
                builder.InputFilePaths.AddRange(FileList);
                ret.Add(builder.GenerateCommand());
            }
            return ret.ToArray();
        }
    }
}
