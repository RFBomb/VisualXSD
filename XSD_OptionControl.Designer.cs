
namespace XSD_Tool_Helper
{
    partial class XSD_OptionControl
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chk_Order = new System.Windows.Forms.CheckBox();
            this.chk_DataBinding = new System.Windows.Forms.CheckBox();
            this.chk_SuppressBanner = new System.Windows.Forms.CheckBox();
            this.chk_LinqDataSet = new System.Windows.Forms.CheckBox();
            this.chk_Fields = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_DataSetClass = new System.Windows.Forms.RadioButton();
            this.radio_SerialClass = new System.Windows.Forms.RadioButton();
            this.GroupBox_Options = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_URI = new System.Windows.Forms.TextBox();
            this.listBox_Elements = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ClearSelected = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Element = new System.Windows.Forms.TextBox();
            this.btn_AddElement = new System.Windows.Forms.Button();
            this.GroupBox_Elements = new System.Windows.Forms.GroupBox();
            this.GroupBox_Main = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.GroupBox_Options.SuspendLayout();
            this.GroupBox_Elements.SuspendLayout();
            this.GroupBox_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // chk_Order
            // 
            this.chk_Order.AutoSize = true;
            this.chk_Order.Location = new System.Drawing.Point(6, 22);
            this.chk_Order.Name = "chk_Order";
            this.chk_Order.Size = new System.Drawing.Size(56, 19);
            this.chk_Order.TabIndex = 1;
            this.chk_Order.Text = "Order";
            this.chk_Order.UseVisualStyleBackColor = true;
            // 
            // chk_DataBinding
            // 
            this.chk_DataBinding.AutoSize = true;
            this.chk_DataBinding.Location = new System.Drawing.Point(125, 72);
            this.chk_DataBinding.Name = "chk_DataBinding";
            this.chk_DataBinding.Size = new System.Drawing.Size(132, 19);
            this.chk_DataBinding.TabIndex = 2;
            this.chk_DataBinding.Text = "Enable Data Binding";
            this.chk_DataBinding.UseVisualStyleBackColor = true;
            // 
            // chk_SuppressBanner
            // 
            this.chk_SuppressBanner.AutoSize = true;
            this.chk_SuppressBanner.Location = new System.Drawing.Point(6, 72);
            this.chk_SuppressBanner.Name = "chk_SuppressBanner";
            this.chk_SuppressBanner.Size = new System.Drawing.Size(113, 19);
            this.chk_SuppressBanner.TabIndex = 4;
            this.chk_SuppressBanner.Text = "Suppress Banner";
            this.chk_SuppressBanner.UseVisualStyleBackColor = true;
            // 
            // chk_LinqDataSet
            // 
            this.chk_LinqDataSet.AutoSize = true;
            this.chk_LinqDataSet.Location = new System.Drawing.Point(125, 47);
            this.chk_LinqDataSet.Name = "chk_LinqDataSet";
            this.chk_LinqDataSet.Size = new System.Drawing.Size(130, 19);
            this.chk_LinqDataSet.TabIndex = 3;
            this.chk_LinqDataSet.Text = "Enable Linq DataSet";
            this.chk_LinqDataSet.UseVisualStyleBackColor = true;
            // 
            // chk_Fields
            // 
            this.chk_Fields.AutoSize = true;
            this.chk_Fields.Location = new System.Drawing.Point(6, 47);
            this.chk_Fields.Name = "chk_Fields";
            this.chk_Fields.Size = new System.Drawing.Size(56, 19);
            this.chk_Fields.TabIndex = 6;
            this.chk_Fields.Text = "Fields";
            this.chk_Fields.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radio_DataSetClass);
            this.groupBox1.Controls.Add(this.radio_SerialClass);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 70);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Language";
            // 
            // radio_DataSetClass
            // 
            this.radio_DataSetClass.AutoSize = true;
            this.radio_DataSetClass.Location = new System.Drawing.Point(6, 42);
            this.radio_DataSetClass.Name = "radio_DataSetClass";
            this.radio_DataSetClass.Size = new System.Drawing.Size(145, 19);
            this.radio_DataSetClass.TabIndex = 1;
            this.radio_DataSetClass.TabStop = true;
            this.radio_DataSetClass.Text = "Generate DataSet Class";
            this.radio_DataSetClass.UseVisualStyleBackColor = true;
            this.radio_DataSetClass.CheckedChanged += new System.EventHandler(this.radio_DataSetClass_CheckedChanged);
            // 
            // radio_SerialClass
            // 
            this.radio_SerialClass.AutoSize = true;
            this.radio_SerialClass.Location = new System.Drawing.Point(6, 22);
            this.radio_SerialClass.Name = "radio_SerialClass";
            this.radio_SerialClass.Size = new System.Drawing.Size(163, 19);
            this.radio_SerialClass.TabIndex = 0;
            this.radio_SerialClass.TabStop = true;
            this.radio_SerialClass.Text = "Generate Serializable Class";
            this.radio_SerialClass.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Options
            // 
            this.GroupBox_Options.Controls.Add(this.chk_LinqDataSet);
            this.GroupBox_Options.Controls.Add(this.label2);
            this.GroupBox_Options.Controls.Add(this.chk_Order);
            this.GroupBox_Options.Controls.Add(this.txt_URI);
            this.GroupBox_Options.Controls.Add(this.chk_Fields);
            this.GroupBox_Options.Controls.Add(this.chk_DataBinding);
            this.GroupBox_Options.Controls.Add(this.chk_SuppressBanner);
            this.GroupBox_Options.Location = new System.Drawing.Point(6, 98);
            this.GroupBox_Options.Name = "GroupBox_Options";
            this.GroupBox_Options.Size = new System.Drawing.Size(305, 108);
            this.GroupBox_Options.TabIndex = 8;
            this.GroupBox_Options.TabStop = false;
            this.GroupBox_Options.Text = "Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "URI";
            // 
            // txt_URI
            // 
            this.txt_URI.Location = new System.Drawing.Point(156, 18);
            this.txt_URI.Name = "txt_URI";
            this.txt_URI.Size = new System.Drawing.Size(139, 23);
            this.txt_URI.TabIndex = 7;
            // 
            // listBox_Elements
            // 
            this.listBox_Elements.FormattingEnabled = true;
            this.listBox_Elements.ItemHeight = 15;
            this.listBox_Elements.Location = new System.Drawing.Point(8, 83);
            this.listBox_Elements.Name = "listBox_Elements";
            this.listBox_Elements.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_Elements.Size = new System.Drawing.Size(161, 94);
            this.listBox_Elements.TabIndex = 8;
            this.listBox_Elements.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox_Elements_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Element List";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(175, 155);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(90, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear List";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ClearSelected
            // 
            this.btn_ClearSelected.Location = new System.Drawing.Point(175, 126);
            this.btn_ClearSelected.Name = "btn_ClearSelected";
            this.btn_ClearSelected.Size = new System.Drawing.Size(90, 23);
            this.btn_ClearSelected.TabIndex = 11;
            this.btn_ClearSelected.Text = "Clear Selected";
            this.btn_ClearSelected.UseVisualStyleBackColor = true;
            this.btn_ClearSelected.Click += new System.EventHandler(this.btn_ClearSelected_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Element to Add";
            // 
            // txt_Element
            // 
            this.txt_Element.Location = new System.Drawing.Point(8, 35);
            this.txt_Element.Name = "txt_Element";
            this.txt_Element.Size = new System.Drawing.Size(161, 23);
            this.txt_Element.TabIndex = 12;
            this.txt_Element.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Element_KeyPress);
            // 
            // btn_AddElement
            // 
            this.btn_AddElement.Location = new System.Drawing.Point(175, 35);
            this.btn_AddElement.Name = "btn_AddElement";
            this.btn_AddElement.Size = new System.Drawing.Size(90, 23);
            this.btn_AddElement.TabIndex = 14;
            this.btn_AddElement.Text = "Add";
            this.btn_AddElement.UseVisualStyleBackColor = true;
            this.btn_AddElement.Click += new System.EventHandler(this.btn_AddElement_Click);
            // 
            // GroupBox_Elements
            // 
            this.GroupBox_Elements.Controls.Add(this.label4);
            this.GroupBox_Elements.Controls.Add(this.btn_AddElement);
            this.GroupBox_Elements.Controls.Add(this.listBox_Elements);
            this.GroupBox_Elements.Controls.Add(this.label3);
            this.GroupBox_Elements.Controls.Add(this.txt_Element);
            this.GroupBox_Elements.Controls.Add(this.btn_Clear);
            this.GroupBox_Elements.Controls.Add(this.btn_ClearSelected);
            this.GroupBox_Elements.Location = new System.Drawing.Point(317, 22);
            this.GroupBox_Elements.Name = "GroupBox_Elements";
            this.GroupBox_Elements.Size = new System.Drawing.Size(271, 184);
            this.GroupBox_Elements.TabIndex = 15;
            this.GroupBox_Elements.TabStop = false;
            // 
            // GroupBox_Main
            // 
            this.GroupBox_Main.Controls.Add(this.groupBox1);
            this.GroupBox_Main.Controls.Add(this.GroupBox_Elements);
            this.GroupBox_Main.Controls.Add(this.GroupBox_Options);
            this.GroupBox_Main.Location = new System.Drawing.Point(3, 3);
            this.GroupBox_Main.Name = "GroupBox_Main";
            this.GroupBox_Main.Size = new System.Drawing.Size(595, 212);
            this.GroupBox_Main.TabIndex = 16;
            this.GroupBox_Main.TabStop = false;
            this.GroupBox_Main.Text = "XSD Processing Options";
            // 
            // XSD_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_Main);
            this.Name = "XSD_OptionControl";
            this.Size = new System.Drawing.Size(604, 216);
            this.Load += new System.EventHandler(this.XSD_OptionControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox_Options.ResumeLayout(false);
            this.GroupBox_Options.PerformLayout();
            this.GroupBox_Elements.ResumeLayout(false);
            this.GroupBox_Elements.PerformLayout();
            this.GroupBox_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chk_Order;
        private System.Windows.Forms.CheckBox chk_DataBinding;
        private System.Windows.Forms.CheckBox chk_SuppressBanner;
        private System.Windows.Forms.CheckBox chk_LinqDataSet;
        private System.Windows.Forms.CheckBox chk_Fields;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_DataSetClass;
        private System.Windows.Forms.RadioButton radio_SerialClass;
        private System.Windows.Forms.GroupBox GroupBox_Options;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_URI;
        private System.Windows.Forms.ListBox listBox_Elements;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ClearSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Element;
        private System.Windows.Forms.Button btn_AddElement;
        private System.Windows.Forms.GroupBox GroupBox_Elements;
        private System.Windows.Forms.GroupBox GroupBox_Main;
    }
}
