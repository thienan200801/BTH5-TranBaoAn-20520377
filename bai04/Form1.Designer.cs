namespace bai04
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1_FontFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2_SizeBox = new System.Windows.Forms.ComboBox();
            this.checkBox1_Bold = new System.Windows.Forms.CheckBox();
            this.checkBox2_Italic = new System.Windows.Forms.CheckBox();
            this.checkBox3_Underline = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3_Right = new System.Windows.Forms.RadioButton();
            this.radioButton2_Center = new System.Windows.Forms.RadioButton();
            this.radioButton1_Left = new System.Windows.Forms.RadioButton();
            this.richTextBox1_Preview = new System.Windows.Forms.RichTextBox();
            this.button_chooseColor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1_FontFamily
            // 
            this.comboBox1_FontFamily.FormattingEnabled = true;
            this.comboBox1_FontFamily.Location = new System.Drawing.Point(81, 48);
            this.comboBox1_FontFamily.Name = "comboBox1_FontFamily";
            this.comboBox1_FontFamily.Size = new System.Drawing.Size(245, 23);
            this.comboBox1_FontFamily.TabIndex = 0;
            this.comboBox1_FontFamily.SelectedIndexChanged += new System.EventHandler(this.comboBox1_FontFamily_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(380, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(380, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color";
            // 
            // comboBox2_SizeBox
            // 
            this.comboBox2_SizeBox.FormattingEnabled = true;
            this.comboBox2_SizeBox.Location = new System.Drawing.Point(430, 48);
            this.comboBox2_SizeBox.Name = "comboBox2_SizeBox";
            this.comboBox2_SizeBox.Size = new System.Drawing.Size(175, 23);
            this.comboBox2_SizeBox.TabIndex = 4;
            this.comboBox2_SizeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SizeBox_SelectedIndexChanged);
            // 
            // checkBox1_Bold
            // 
            this.checkBox1_Bold.AutoSize = true;
            this.checkBox1_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1_Bold.Location = new System.Drawing.Point(32, 103);
            this.checkBox1_Bold.Name = "checkBox1_Bold";
            this.checkBox1_Bold.Size = new System.Drawing.Size(48, 29);
            this.checkBox1_Bold.TabIndex = 5;
            this.checkBox1_Bold.Text = "B";
            this.checkBox1_Bold.UseVisualStyleBackColor = true;
            this.checkBox1_Bold.CheckedChanged += new System.EventHandler(this.checkBox1_Bold_CheckedChanged);
            // 
            // checkBox2_Italic
            // 
            this.checkBox2_Italic.AutoSize = true;
            this.checkBox2_Italic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2_Italic.Location = new System.Drawing.Point(113, 103);
            this.checkBox2_Italic.Name = "checkBox2_Italic";
            this.checkBox2_Italic.Size = new System.Drawing.Size(39, 26);
            this.checkBox2_Italic.TabIndex = 6;
            this.checkBox2_Italic.Text = "I";
            this.checkBox2_Italic.UseVisualStyleBackColor = true;
            this.checkBox2_Italic.CheckedChanged += new System.EventHandler(this.checkBox2_Italic_CheckedChanged);
            // 
            // checkBox3_Underline
            // 
            this.checkBox3_Underline.AutoSize = true;
            this.checkBox3_Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3_Underline.Location = new System.Drawing.Point(186, 101);
            this.checkBox3_Underline.Name = "checkBox3_Underline";
            this.checkBox3_Underline.Size = new System.Drawing.Size(48, 29);
            this.checkBox3_Underline.TabIndex = 7;
            this.checkBox3_Underline.Text = "U";
            this.checkBox3_Underline.UseVisualStyleBackColor = true;
            this.checkBox3_Underline.CheckedChanged += new System.EventHandler(this.checkBox3_Underline_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3_Right);
            this.groupBox1.Controls.Add(this.radioButton2_Center);
            this.groupBox1.Controls.Add(this.radioButton1_Left);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.groupBox1.Location = new System.Drawing.Point(32, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 183);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // radioButton3_Right
            // 
            this.radioButton3_Right.AutoSize = true;
            this.radioButton3_Right.Location = new System.Drawing.Point(19, 123);
            this.radioButton3_Right.Name = "radioButton3_Right";
            this.radioButton3_Right.Size = new System.Drawing.Size(73, 26);
            this.radioButton3_Right.TabIndex = 2;
            this.radioButton3_Right.TabStop = true;
            this.radioButton3_Right.Text = "Right";
            this.radioButton3_Right.UseVisualStyleBackColor = true;
            this.radioButton3_Right.CheckedChanged += new System.EventHandler(this.radioButton3_Right_CheckedChanged);
            // 
            // radioButton2_Center
            // 
            this.radioButton2_Center.AutoSize = true;
            this.radioButton2_Center.Location = new System.Drawing.Point(19, 81);
            this.radioButton2_Center.Name = "radioButton2_Center";
            this.radioButton2_Center.Size = new System.Drawing.Size(83, 26);
            this.radioButton2_Center.TabIndex = 1;
            this.radioButton2_Center.TabStop = true;
            this.radioButton2_Center.Text = "Center";
            this.radioButton2_Center.UseVisualStyleBackColor = true;
            this.radioButton2_Center.CheckedChanged += new System.EventHandler(this.radioButton2_Center_CheckedChanged);
            // 
            // radioButton1_Left
            // 
            this.radioButton1_Left.AutoSize = true;
            this.radioButton1_Left.Location = new System.Drawing.Point(19, 39);
            this.radioButton1_Left.Name = "radioButton1_Left";
            this.radioButton1_Left.Size = new System.Drawing.Size(62, 26);
            this.radioButton1_Left.TabIndex = 0;
            this.radioButton1_Left.TabStop = true;
            this.radioButton1_Left.Text = "Left";
            this.radioButton1_Left.UseVisualStyleBackColor = true;
            this.radioButton1_Left.CheckedChanged += new System.EventHandler(this.radioButton1_Left_CheckedChanged);
            // 
            // richTextBox1_Preview
            // 
            this.richTextBox1_Preview.Location = new System.Drawing.Point(328, 188);
            this.richTextBox1_Preview.Name = "richTextBox1_Preview";
            this.richTextBox1_Preview.Size = new System.Drawing.Size(360, 93);
            this.richTextBox1_Preview.TabIndex = 16;
            this.richTextBox1_Preview.Text = "";
            // 
            // button_chooseColor
            // 
            this.button_chooseColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_chooseColor.Location = new System.Drawing.Point(457, 82);
            this.button_chooseColor.Name = "button_chooseColor";
            this.button_chooseColor.Size = new System.Drawing.Size(50, 50);
            this.button_chooseColor.TabIndex = 17;
            this.button_chooseColor.UseVisualStyleBackColor = false;
            this.button_chooseColor.Click += new System.EventHandler(this.button_chooseColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.button_chooseColor);
            this.Controls.Add(this.richTextBox1_Preview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox3_Underline);
            this.Controls.Add(this.checkBox2_Italic);
            this.Controls.Add(this.checkBox1_Bold);
            this.Controls.Add(this.comboBox2_SizeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1_FontFamily);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_FontFamily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2_SizeBox;
        private System.Windows.Forms.CheckBox checkBox1_Bold;
        private System.Windows.Forms.CheckBox checkBox2_Italic;
        private System.Windows.Forms.CheckBox checkBox3_Underline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3_Right;
        private System.Windows.Forms.RadioButton radioButton2_Center;
        private System.Windows.Forms.RadioButton radioButton1_Left;
        private System.Windows.Forms.RichTextBox richTextBox1_Preview;
        private System.Windows.Forms.Button button_chooseColor;
    }
}

