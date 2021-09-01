
namespace XSD_Tool_Helper
{
    partial class Control_XSD
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_XSD));
            this.xsD_OptionControl1 = new XSD_Tool_Helper.XSD_OptionControl();
            this.control_FileList1 = new XSD_Tool_Helper.Control_FileList();
            this.control_ParameterFileGeneration1 = new XSD_Tool_Helper.Control_ParameterFileGeneration();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xsD_OptionControl1
            // 
            this.xsD_OptionControl1.ElementList = ((System.Collections.Generic.List<string>)(resources.GetObject("xsD_OptionControl1.ElementList")));
            this.xsD_OptionControl1.Location = new System.Drawing.Point(0, 205);
            this.xsD_OptionControl1.Name = "xsD_OptionControl1";
            this.xsD_OptionControl1.ParentControl = null;
            this.xsD_OptionControl1.Size = new System.Drawing.Size(604, 220);
            this.xsD_OptionControl1.TabIndex = 0;
            // 
            // control_FileList1
            // 
            this.control_FileList1.DestFolder = null;
            this.control_FileList1.FileType = XSD_Tool_Helper.Control_FileList.FileTypes.XML;
            this.control_FileList1.Location = new System.Drawing.Point(3, 3);
            this.control_FileList1.Name = "control_FileList1";
            this.control_FileList1.NameSpace = "";
            this.control_FileList1.Size = new System.Drawing.Size(481, 207);
            this.control_FileList1.TabIndex = 1;
            // 
            // control_ParameterFileGeneration1
            // 
            this.control_ParameterFileGeneration1.Location = new System.Drawing.Point(3, 431);
            this.control_ParameterFileGeneration1.Name = "control_ParameterFileGeneration1";
            this.control_ParameterFileGeneration1.Size = new System.Drawing.Size(424, 72);
            this.control_ParameterFileGeneration1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Run XSD Tool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Control_XSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.control_ParameterFileGeneration1);
            this.Controls.Add(this.control_FileList1);
            this.Controls.Add(this.xsD_OptionControl1);
            this.Name = "Control_XSD";
            this.Size = new System.Drawing.Size(605, 512);
            this.Load += new System.EventHandler(this.Control_XSD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private XSD_OptionControl xsD_OptionControl1;
        private Control_FileList control_FileList1;
        private Control_ParameterFileGeneration control_ParameterFileGeneration1;
        private System.Windows.Forms.Button button1;
    }
}
