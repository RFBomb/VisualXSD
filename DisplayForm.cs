using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace XSD_Tool_Helper
{
    public partial class DisplayForm : Form
    {
        private DisplayForm()
        {
            InitializeComponent();
        }

        public DisplayForm(string[] arguments)
        {
            InitializeComponent();
            this.Arguments = arguments;
        }

        public Process XPro { get; set; }
        public string[] Arguments { get; set; }

        public async void RUN()
        {
            foreach (string args in Arguments)
            {
                using (XPro = new Process())
                {

                    AppendTextBox($"Current Command Arguments: {args}{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}");

                    XPro.StartInfo.FileName = StaticMethods.XSD_Path;
                    XPro.StartInfo.Arguments = args;
                    XPro.StartInfo.UseShellExecute = false;
                    XPro.StartInfo.RedirectStandardOutput = true;
                    //XPro.OutputDataReceived += XPro_OutputDataReceived;
                    XPro.Start();
                    StreamReader rdr = XPro.StandardOutput;
                    string str = rdr.ReadToEnd();
                    AppendTextBox(str);
                    await XPro.WaitForExitAsync();
                }  
                
            }
        }

        private void XPro_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            AppendTextBox(e.Data);
        }


        public void AppendTextBox(string value)
        {
            string append = $"{value}"; //{Environment.NewLine}
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { append });
                return;
            }
            textBox1.Text += append;
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            
            RUN();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
