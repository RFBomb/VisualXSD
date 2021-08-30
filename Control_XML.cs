﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XSD_Tool_Helper
{
    public partial class Control_XML : UserControl, IMasterControl
    {
        public Control_XML()
        {
            InitializeComponent();
            this.Radio_CreateClasses.Checked = true;
            this.control_FileList1.FileType = Control_FileList.FileTypes.XML;
            this.xsD_OptionControl1.ParentControl = this;
        }

        public string NameSpace => this.control_FileList1.NameSpace;

        public string OutputFileName => this.control_FileList1.OutputFileName;

        public bool ParamFileContainsFilePaths => false;//throw new NotImplementedException();

        public bool GenerateParamFile => false;//throw new NotImplementedException();

        public bool ProcessIndividually => this.control_FileList1.ProcessIndividually;

        public DirectoryInfo OutputFolder => this.control_FileList1.DestFolder;

        public List<FileInfo> InputFileList => this.control_FileList1.GetFileList();

        public string[] GenerateCommand()
        {
            List<string> ret = new();
            //Setup the XMLProc object
            XSD xmlProc = new();
            xmlProc.GenerateParameterFile = this.chk_GenerateParamFile.Checked;
            xmlProc.OutputDirectory = this.OutputFolder?.FullName;
            xmlProc.ParameterFileContainsInputFiles = false;
            
            if (this.control_FileList1.ProcessIndividually)
            {
                foreach (FileInfo file in InputFileList)
                {
                    xmlProc.InputFilePaths.Clear();
                    xmlProc.InputFilePaths.Add(file);
                    ret.Add(xmlProc.GenerateCommand());
                }
            }
            else
            {
                xmlProc.InputFilePaths.AddRange(InputFileList);
                ret.Add(xmlProc.GenerateCommand());
            }

            if (this.Radio_CreateClasses.Checked)
                ret.AddRange(this.xsD_OptionControl1.GenerateCommand().ToArray());

            return ret.ToArray();
        }

        

        public void Run()
        {
            DisplayForm frm = new(GenerateCommand());
            frm.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.xsD_OptionControl1.Enabled = this.Radio_CreateClasses.Checked;
        }

        private void Control_XML_Load(object sender, EventArgs e)
        {

        }

        private void btn_LoadConfig_Click(object sender, EventArgs e)
        {

        }

        private void chk_GenerateParamFile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StaticMethods.ValidateNameSpace(this.NameSpace, out string ValidatedNameSpace))
            {
                this.control_FileList1.NameSpace = ValidatedNameSpace;
                this.Run();
            }
            
        }
    }
}
