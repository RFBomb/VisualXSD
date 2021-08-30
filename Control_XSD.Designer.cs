
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
            this.xsD_OptionControl1 = new XSD_Tool_Helper.XSD_OptionControl();
            this.control_FileList1 = new XSD_Tool_Helper.Control_FileList();
            this.SuspendLayout();
            // 
            // xsD_OptionControl1
            // 
            this.xsD_OptionControl1.Location = new System.Drawing.Point(3, 191);
            this.xsD_OptionControl1.Name = "xsD_OptionControl1";
            this.xsD_OptionControl1.Size = new System.Drawing.Size(604, 278);
            this.xsD_OptionControl1.TabIndex = 0;
            // 
            // control_FileList1
            // 
            this.control_FileList1.Location = new System.Drawing.Point(55, 3);
            this.control_FileList1.Name = "control_FileList1";
            this.control_FileList1.Size = new System.Drawing.Size(481, 182);
            this.control_FileList1.TabIndex = 1;
            // 
            // Control_XSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.control_FileList1);
            this.Controls.Add(this.xsD_OptionControl1);
            this.Name = "Control_XSD";
            this.Size = new System.Drawing.Size(605, 473);
            this.ResumeLayout(false);

        }

        #endregion

        private XSD_OptionControl xsD_OptionControl1;
        private Control_FileList control_FileList1;
    }
}
