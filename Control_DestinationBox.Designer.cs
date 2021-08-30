
namespace XSD_Tool_Helper
{
    partial class Control_DestinationBox
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
            this.lbl_DestFolder = new System.Windows.Forms.Label();
            this.btn_BrowseDest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_DestFolder
            // 
            this.lbl_DestFolder.AutoSize = true;
            this.lbl_DestFolder.Location = new System.Drawing.Point(16, 16);
            this.lbl_DestFolder.Name = "lbl_DestFolder";
            this.lbl_DestFolder.Size = new System.Drawing.Size(103, 15);
            this.lbl_DestFolder.TabIndex = 11;
            this.lbl_DestFolder.Text = "Destination Folder";
            // 
            // btn_BrowseDest
            // 
            this.btn_BrowseDest.Location = new System.Drawing.Point(162, 33);
            this.btn_BrowseDest.Name = "btn_BrowseDest";
            this.btn_BrowseDest.Size = new System.Drawing.Size(75, 23);
            this.btn_BrowseDest.TabIndex = 10;
            this.btn_BrowseDest.Text = "Browse";
            this.btn_BrowseDest.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
            // 
            // Control_DestinationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_DestFolder);
            this.Controls.Add(this.btn_BrowseDest);
            this.Controls.Add(this.textBox1);
            this.Name = "Control_DestinationBox";
            this.Size = new System.Drawing.Size(251, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DestFolder;
        private System.Windows.Forms.Button btn_BrowseDest;
        private System.Windows.Forms.TextBox textBox1;
    }
}
