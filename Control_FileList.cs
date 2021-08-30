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
    public partial class Control_FileList : UserControl
    {
        public Control_FileList()
        {
            InitializeComponent();
            this.txt_DestFolder.ReadOnly = true;
        }

        public enum FileTypes
        {
            XML, XSD, XDR, Assy
        }

        private List<FileInfo> FileList { get; set; } = new List<FileInfo>();

        public bool ProcessIndividually => this.radio_Individual.Checked;

        public FileTypes FileType { get; set; }

        public DirectoryInfo DestFolder { get; set; }

        public string NameSpace
        {
            get => this.txt_NameSpace.Text;
            set => this.txt_NameSpace.Text = value;
        }

        public string OutputFileName => this.txt_DestName.Text;

        public List<FileInfo> GetFileList()
        {
            List<FileInfo> ret = new List<FileInfo>();
            ret.AddRange(FileList);
            if (String.IsNullOrWhiteSpace(this.txt_DestName.Text))
                return ret;

            //Process the filename
            string destname = this.txt_DestName.Text;
            FileInfo name = this.FileType switch
            {
                FileTypes.XML => new FileInfo(ChangeExtension(destname, ".xml")),
                FileTypes.XSD => new FileInfo(ChangeExtension(destname, ".xsd")),
                FileTypes.XDR => new FileInfo(ChangeExtension(destname, ".xdr")),
                FileTypes.Assy => new FileInfo(ChangeExtension(destname, ".dll")),
                _ => new FileInfo(ChangeExtension(destname, ".xml")),
            };
            ret.Add(name);
            return ret;
        }

        private string ChangeExtension(string InputString, string Ext)
        {
            if (Path.HasExtension(InputString))
            {
                return Path.ChangeExtension(InputString, Ext);
            }
            else
            {
                return InputString + Ext;
            }
        }

        private void btn_AddFiles_Click(object sender, EventArgs e)
        {
            List<FileInfo> list = GetFiles();
            this.FileList.AddRange(list);
            RefreshDisplayList();
        }

        private void RefreshDisplayList()
        {
            this.listbox_SelectedFiles.DataSource = new BindingSource(FileList, null);
            this.listbox_SelectedFiles.DisplayMember = ".Name";
            if (FileList.Count > 1 && this.radio_Individual.Checked)
                this.txt_DestName.ReadOnly = true;
            else
                this.txt_DestName.ReadOnly = false;
        }

        private List<FileInfo> GetFiles() 
        {
            switch(this.FileType)
            {
                case FileTypes.XML: return StaticMethods.FilePicker_XML;
                case FileTypes.XSD: return StaticMethods.FilePicker_XSD;
                case FileTypes.XDR: return StaticMethods.FilePicker_XML;
                case FileTypes.Assy: return StaticMethods.FilePicker_Assy;
                default: return StaticMethods.FilePicker_XML;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(this, "Remove selectecd files from the listbox?", "Are you sure?", MessageBoxButtons.YesNo);
            if (ask == DialogResult.No)
                return;
            foreach (FileInfo str in this.listbox_SelectedFiles.SelectedItems)
                FileList.Remove(str);
            RefreshDisplayList();

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(this, "Remove all files from the listbox?", "Are you sure?", MessageBoxButtons.YesNo);
            if (ask == DialogResult.Yes)
            {
                this.FileList.Clear();
                RefreshDisplayList();
            }
        }

        private void Control_FileList_Load(object sender, EventArgs e)
        {
            RefreshDisplayList();
            this.radio_Individual.Checked = true;
        }

        private void radio_Individual_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            DestFolder = StaticMethods.FolderPicker();
            string path = DestFolder?.FullName;
            if (!String.IsNullOrWhiteSpace(path))
                this.txt_DestFolder.Text = path;
        }
    }
}
