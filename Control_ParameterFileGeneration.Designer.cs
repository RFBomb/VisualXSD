
namespace XSD_Tool_Helper
{
    partial class Control_ParameterFileGeneration
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
            this.GroupBox_Params = new System.Windows.Forms.GroupBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chk_GenerateParamFile = new System.Windows.Forms.CheckBox();
            this.GroupBox_Params.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Params
            // 
            this.GroupBox_Params.Controls.Add(this.btn_Create);
            this.GroupBox_Params.Controls.Add(this.btn_Load);
            this.GroupBox_Params.Controls.Add(this.checkBox1);
            this.GroupBox_Params.Controls.Add(this.chk_GenerateParamFile);
            this.GroupBox_Params.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Params.Name = "GroupBox_Params";
            this.GroupBox_Params.Size = new System.Drawing.Size(421, 71);
            this.GroupBox_Params.TabIndex = 19;
            this.GroupBox_Params.TabStop = false;
            this.GroupBox_Params.Text = "Parameter File Options";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(274, 13);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(139, 23);
            this.btn_Create.TabIndex = 18;
            this.btn_Create.Text = "Create Parameter File";
            this.btn_Create.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(274, 42);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(139, 23);
            this.btn_Load.TabIndex = 15;
            this.btn_Load.Text = "Load Parameter File";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
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
            // 
            // Control_ParameterFileGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_Params);
            this.Name = "Control_ParameterFileGeneration";
            this.Size = new System.Drawing.Size(425, 72);
            this.GroupBox_Params.ResumeLayout(false);
            this.GroupBox_Params.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Params;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chk_GenerateParamFile;
    }
}
