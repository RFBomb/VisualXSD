
namespace XSD_Tool_Helper
{
    partial class Control_FileList
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
            this.label1 = new System.Windows.Forms.Label();
            this.listbox_SelectedFiles = new System.Windows.Forms.ListBox();
            this.lbl_DestFileName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_AsUnit = new System.Windows.Forms.RadioButton();
            this.radio_Individual = new System.Windows.Forms.RadioButton();
            this.txt_DestName = new System.Windows.Forms.TextBox();
            this.btn_AddFiles = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_DestFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txt_NameSpace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Files to Convert";
            // 
            // listbox_SelectedFiles
            // 
            this.listbox_SelectedFiles.FormattingEnabled = true;
            this.listbox_SelectedFiles.ItemHeight = 15;
            this.listbox_SelectedFiles.Location = new System.Drawing.Point(3, 77);
            this.listbox_SelectedFiles.Name = "listbox_SelectedFiles";
            this.listbox_SelectedFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listbox_SelectedFiles.Size = new System.Drawing.Size(206, 124);
            this.listbox_SelectedFiles.TabIndex = 12;
            // 
            // lbl_DestFileName
            // 
            this.lbl_DestFileName.AutoSize = true;
            this.lbl_DestFileName.Location = new System.Drawing.Point(296, 77);
            this.lbl_DestFileName.Name = "lbl_DestFileName";
            this.lbl_DestFileName.Size = new System.Drawing.Size(118, 15);
            this.lbl_DestFileName.TabIndex = 14;
            this.lbl_DestFileName.Text = "Destination Filename";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_AsUnit);
            this.groupBox1.Controls.Add(this.radio_Individual);
            this.groupBox1.Location = new System.Drawing.Point(296, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 83);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // radio_AsUnit
            // 
            this.radio_AsUnit.AutoSize = true;
            this.radio_AsUnit.Location = new System.Drawing.Point(6, 47);
            this.radio_AsUnit.Name = "radio_AsUnit";
            this.radio_AsUnit.Size = new System.Drawing.Size(155, 19);
            this.radio_AsUnit.TabIndex = 1;
            this.radio_AsUnit.TabStop = true;
            this.radio_AsUnit.Text = "Process as a single Entity";
            this.radio_AsUnit.UseVisualStyleBackColor = true;
            // 
            // radio_Individual
            // 
            this.radio_Individual.AutoSize = true;
            this.radio_Individual.Location = new System.Drawing.Point(6, 22);
            this.radio_Individual.Name = "radio_Individual";
            this.radio_Individual.Size = new System.Drawing.Size(129, 19);
            this.radio_Individual.TabIndex = 0;
            this.radio_Individual.TabStop = true;
            this.radio_Individual.Text = "Process Individually";
            this.radio_Individual.UseVisualStyleBackColor = true;
            this.radio_Individual.CheckedChanged += new System.EventHandler(this.radio_Individual_CheckedChanged);
            // 
            // txt_DestName
            // 
            this.txt_DestName.Location = new System.Drawing.Point(296, 95);
            this.txt_DestName.Name = "txt_DestName";
            this.txt_DestName.Size = new System.Drawing.Size(178, 23);
            this.txt_DestName.TabIndex = 16;
            // 
            // btn_AddFiles
            // 
            this.btn_AddFiles.Location = new System.Drawing.Point(215, 77);
            this.btn_AddFiles.Name = "btn_AddFiles";
            this.btn_AddFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFiles.TabIndex = 17;
            this.btn_AddFiles.Text = "Add File(s)";
            this.btn_AddFiles.UseVisualStyleBackColor = true;
            this.btn_AddFiles.Click += new System.EventHandler(this.btn_AddFiles_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(215, 106);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 18;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(215, 135);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 19;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_DestFolder
            // 
            this.txt_DestFolder.Location = new System.Drawing.Point(112, 3);
            this.txt_DestFolder.Name = "txt_DestFolder";
            this.txt_DestFolder.Size = new System.Drawing.Size(281, 23);
            this.txt_DestFolder.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Destination Folder";
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(399, 3);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 22;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // txt_NameSpace
            // 
            this.txt_NameSpace.Location = new System.Drawing.Point(120, 32);
            this.txt_NameSpace.Name = "txt_NameSpace";
            this.txt_NameSpace.Size = new System.Drawing.Size(273, 23);
            this.txt_NameSpace.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Output NameSpace";
            // 
            // Control_FileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_NameSpace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.txt_DestFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_AddFiles);
            this.Controls.Add(this.txt_DestName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_DestFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listbox_SelectedFiles);
            this.Name = "Control_FileList";
            this.Size = new System.Drawing.Size(480, 205);
            this.Load += new System.EventHandler(this.Control_FileList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox_SelectedFiles;
        private System.Windows.Forms.Label lbl_DestFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_AsUnit;
        private System.Windows.Forms.RadioButton radio_Individual;
        private System.Windows.Forms.TextBox txt_DestName;
        private System.Windows.Forms.Button btn_AddFiles;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_DestFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_NameSpace;
        private System.Windows.Forms.Label label3;
    }
}
