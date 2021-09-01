
namespace XSD_Tool_Helper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Run = new System.Windows.Forms.Button();
            this.lbl_NameSpace = new System.Windows.Forms.Label();
            this.txt_NameSpace = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.control_xml1 = new XSD_Tool_Helper.Control_XML();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.control_xsd1 = new XSD_Tool_Helper.Control_XSD();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.control_Assemblies1 = new XSD_Tool_Helper.Control_Assemblies();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(621, 404);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(96, 23);
            this.btn_Run.TabIndex = 4;
            this.btn_Run.Text = "Run XSD.exe";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lbl_NameSpace
            // 
            this.lbl_NameSpace.AutoSize = true;
            this.lbl_NameSpace.Location = new System.Drawing.Point(109, 369);
            this.lbl_NameSpace.Name = "lbl_NameSpace";
            this.lbl_NameSpace.Size = new System.Drawing.Size(70, 15);
            this.lbl_NameSpace.TabIndex = 16;
            this.lbl_NameSpace.Text = "NameSpace";
            // 
            // txt_NameSpace
            // 
            this.txt_NameSpace.Location = new System.Drawing.Point(132, 387);
            this.txt_NameSpace.Name = "txt_NameSpace";
            this.txt_NameSpace.Size = new System.Drawing.Size(100, 23);
            this.txt_NameSpace.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 333);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.control_xml1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "XML Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // control_xml1
            // 
            this.control_xml1.AutoSize = true;
            this.control_xml1.Location = new System.Drawing.Point(48, 21);
            this.control_xml1.Name = "control_xml1";
            this.control_xml1.Size = new System.Drawing.Size(770, 574);
            this.control_xml1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.control_xsd1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(817, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XSD Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // control_xsd1
            // 
            this.control_xsd1.Location = new System.Drawing.Point(3, 3);
            this.control_xsd1.Name = "control_xsd1";
            this.control_xsd1.Size = new System.Drawing.Size(732, 494);
            this.control_xsd1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.control_Assemblies1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(817, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assemblies (DLL / EXE)";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // control_Assemblies1
            // 
            this.control_Assemblies1.Location = new System.Drawing.Point(6, 6);
            this.control_Assemblies1.Name = "control_Assemblies1";
            this.control_Assemblies1.Size = new System.Drawing.Size(382, 236);
            this.control_Assemblies1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(973, 642);
            this.Controls.Add(this.lbl_NameSpace);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txt_NameSpace);
            this.Controls.Add(this.btn_Run);
            this.Name = "MainForm";
            this.Text = "VisualXSD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label lbl_NameSpace;
        private System.Windows.Forms.TextBox txt_NameSpace;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Control_XML control_xml1;
        private Control_XSD control_xsd1;
        private Control_Assemblies control_Assemblies1;
    }
}

