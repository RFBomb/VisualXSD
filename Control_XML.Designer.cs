
namespace XSD_Tool_Helper
{
    partial class Control_XML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_XML));
            this.xsD_OptionControl1 = new XSD_Tool_Helper.XSD_OptionControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Radio_CreateClasses = new System.Windows.Forms.RadioButton();
            this.radio_CreateXSD = new System.Windows.Forms.RadioButton();
            this.GroupBox_Params = new System.Windows.Forms.GroupBox();
            this.btn_LoadConfig = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chk_GenerateParamFile = new System.Windows.Forms.CheckBox();
            this.control_FileList1 = new XSD_Tool_Helper.Control_FileList();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GroupBox_Params.SuspendLayout();
            this.SuspendLayout();
            // 
            // xsD_OptionControl1
            // 
            this.xsD_OptionControl1.ElementList = ((System.Collections.Generic.List<string>)(resources.GetObject("xsD_OptionControl1.ElementList")));
            this.xsD_OptionControl1.Location = new System.Drawing.Point(8, 289);
            this.xsD_OptionControl1.Name = "xsD_OptionControl1";
            this.xsD_OptionControl1.ParentControl = null;
            this.xsD_OptionControl1.Size = new System.Drawing.Size(605, 220);
            this.xsD_OptionControl1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Radio_CreateClasses);
            this.groupBox1.Controls.Add(this.radio_CreateXSD);
            this.groupBox1.Location = new System.Drawing.Point(13, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions to Perform";
            // 
            // Radio_CreateClasses
            // 
            this.Radio_CreateClasses.AutoSize = true;
            this.Radio_CreateClasses.Location = new System.Drawing.Point(7, 45);
            this.Radio_CreateClasses.Name = "Radio_CreateClasses";
            this.Radio_CreateClasses.Size = new System.Drawing.Size(147, 19);
            this.Radio_CreateClasses.TabIndex = 1;
            this.Radio_CreateClasses.TabStop = true;
            this.Radio_CreateClasses.Text = "Create XSD and Classes";
            this.Radio_CreateClasses.UseVisualStyleBackColor = true;
            this.Radio_CreateClasses.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radio_CreateXSD
            // 
            this.radio_CreateXSD.AutoSize = true;
            this.radio_CreateXSD.Location = new System.Drawing.Point(7, 20);
            this.radio_CreateXSD.Name = "radio_CreateXSD";
            this.radio_CreateXSD.Size = new System.Drawing.Size(111, 19);
            this.radio_CreateXSD.TabIndex = 0;
            this.radio_CreateXSD.TabStop = true;
            this.radio_CreateXSD.Text = "Create XSD Only";
            this.radio_CreateXSD.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Params
            // 
            this.GroupBox_Params.Controls.Add(this.btn_LoadConfig);
            this.GroupBox_Params.Controls.Add(this.checkBox1);
            this.GroupBox_Params.Controls.Add(this.chk_GenerateParamFile);
            this.GroupBox_Params.Location = new System.Drawing.Point(173, 212);
            this.GroupBox_Params.Name = "GroupBox_Params";
            this.GroupBox_Params.Size = new System.Drawing.Size(436, 71);
            this.GroupBox_Params.TabIndex = 17;
            this.GroupBox_Params.TabStop = false;
            this.GroupBox_Params.Text = "Parameter File Options";
            // 
            // btn_LoadConfig
            // 
            this.btn_LoadConfig.Location = new System.Drawing.Point(291, 23);
            this.btn_LoadConfig.Name = "btn_LoadConfig";
            this.btn_LoadConfig.Size = new System.Drawing.Size(139, 23);
            this.btn_LoadConfig.TabIndex = 15;
            this.btn_LoadConfig.Text = "Load Parameter File";
            this.btn_LoadConfig.UseVisualStyleBackColor = true;
            this.btn_LoadConfig.Click += new System.EventHandler(this.btn_LoadConfig_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 19);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Parameter File Contains FilePaths";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chk_GenerateParamFile
            // 
            this.chk_GenerateParamFile.AutoSize = true;
            this.chk_GenerateParamFile.Location = new System.Drawing.Point(6, 21);
            this.chk_GenerateParamFile.Name = "chk_GenerateParamFile";
            this.chk_GenerateParamFile.Size = new System.Drawing.Size(178, 19);
            this.chk_GenerateParamFile.TabIndex = 16;
            this.chk_GenerateParamFile.Text = "Generate New Parameter File";
            this.chk_GenerateParamFile.UseVisualStyleBackColor = true;
            this.chk_GenerateParamFile.CheckedChanged += new System.EventHandler(this.chk_GenerateParamFile_CheckedChanged);
            // 
            // control_FileList1
            // 
            this.control_FileList1.DestFolder = null;
            this.control_FileList1.FileType = XSD_Tool_Helper.Control_FileList.FileTypes.XML;
            this.control_FileList1.Location = new System.Drawing.Point(13, 3);
            this.control_FileList1.Name = "control_FileList1";
            this.control_FileList1.Size = new System.Drawing.Size(481, 205);
            this.control_FileList1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Run XSD Tool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Control_XML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.control_FileList1);
            this.Controls.Add(this.GroupBox_Params);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.xsD_OptionControl1);
            this.Name = "Control_XML";
            this.Size = new System.Drawing.Size(616, 565);
            this.Load += new System.EventHandler(this.Control_XML_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox_Params.ResumeLayout(false);
            this.GroupBox_Params.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Control_FileList control_FileList1;
        private XSD_OptionControl xsD_OptionControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Radio_CreateClasses;
        private System.Windows.Forms.RadioButton radio_CreateXSD;
        private System.Windows.Forms.GroupBox GroupBox_Params;
        private System.Windows.Forms.Button btn_LoadConfig;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chk_GenerateParamFile;
        private System.Windows.Forms.Button button1;
    }
}
