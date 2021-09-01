using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XSD_Tool_Helper
{
    public partial class Control_ParameterFileGeneration : UserControl
    {
        public Control_ParameterFileGeneration()
        {
            InitializeComponent();
        }


        public bool GenerateParameterFile => this.chk_GenerateParamFile.Checked;
        public bool ParamFileHasName => this.checkBox1.Checked;

        public Object LoadedParamFile { get; private set; }

        enum ParamFileTypes { XML, XSD, ASSY}

        public delegate void LoadParamType();
        public delegate void SaveParamType();

        public event LoadParamType OnParameterLoad_XML;
        public event LoadParamType OnParameterLoad_XSD;
        public event LoadParamType OnParameterLoad_ASSY;

        public event SaveParamType OnParameterSave_XML;
        public event SaveParamType OnParameterSave_XSD;
        public event SaveParamType OnParameterSave_ASSY;

        private void btn_Load_Click(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            OnParameterSave_XML?.Invoke();
            OnParameterSave_XSD?.Invoke();
            OnParameterSave_ASSY?.Invoke();
        }
    }
}
