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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResizeForm();
        }

        /// <summary>
        /// Resizes the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            ResizeForm();
        }

        private void ResizeForm()
        {
            TabPage tab = tabControl1.SelectedTab;
            Control cntrl = tab.Controls[0];
            switch (true)
            {
                case true when tabControl1.TabIndex == 0:
                    //XML Files
                    cntrl = this.control_xml1;
                    break;
                case true when tabControl1.TabIndex == 1:
                    //XSD Files
                    cntrl = this.control_xsd1;
                    break;
                case true when tabControl1.TabIndex == 2:
                    //Assembly Files
                    cntrl = this.control_Assemblies1;
                    break;
            }
            tabControl1.Location = new Point(5, 5);
            //Move the control to correct location
            cntrl.Location = new Point(5, 5);
            //Resize the tab control
            int HeaderHeight = tabControl1.Height - tab.Height;
            tabControl1.Height = HeaderHeight + cntrl.Height + 10;
            tabControl1.Width = cntrl.Width + 10; ;
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            //this.tabControl1.SelectedTab
        }
    }
}
