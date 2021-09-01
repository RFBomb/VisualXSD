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
    public partial class Control_XSD : UserControl, IMasterControl
    {
        public Control_XSD()
        {
            InitializeComponent();
        }

        private void Control_XSD_Load(object sender, EventArgs e)
        {
            this.control_ParameterFileGeneration1.OnParameterLoad_XSD += this.LoadParamFile;
            this.xsD_OptionControl1.ParentControl = this;
        }

        public string NameSpace => this.control_FileList1.NameSpace;

        public string OutputFileName => this.control_FileList1.OutputFileName;

        public bool ParamFileContainsFilePaths => this.control_ParameterFileGeneration1.ParamFileHasName;

        public bool GenerateParamFile => this.control_ParameterFileGeneration1.GenerateParameterFile;

        public bool ProcessIndividually => this.control_FileList1.ProcessIndividually;

        public DirectoryInfo OutputFolder => this.control_FileList1.DestFolder;

        public List<FileInfo> InputFileList => this.control_FileList1.GetFileList();

        private void LoadParamFile()
        {
            //Build File List
            if (this.ParamFileContainsFilePaths)
            {
                this.control_FileList1.ClearFileList();
                this.control_FileList1.AddToFileList(new FileInfo("Test"));
            }

            //Set NameSpace
            this.control_FileList1.NameSpace = "Test";

            //Set Dest Folder
            this.control_FileList1.DestFolder = new DirectoryInfo("Test");

            //Load the data into the XSD control
            this.xsD_OptionControl1.LoadParamFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StaticMethods.ValidateNameSpace(this.NameSpace, out string ValidatedNameSpace))
            {
                this.control_FileList1.NameSpace = ValidatedNameSpace;
                this.Run();
            }
        }

        public void Run()
        {
            DisplayForm frm = new(GenerateCommand());
            frm.Show();
        }

        public string[] GenerateCommand()
        {
            return this.xsD_OptionControl1.GenerateCommand();
        }


    }
}
