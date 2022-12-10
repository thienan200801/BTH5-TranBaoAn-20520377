using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai04
{
    public partial class Form1 : Form
    {
        Color color = Color.Black;
        FontStyle myFontStyle = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
            FontFamily[] fontFamilies;

            richTextBox1_Preview.Text = "Hello world";

            for (int size = 8; size <= 72; size += 4) comboBox2_SizeBox.Items.Add(size);
            comboBox2_SizeBox.Text = "23";

            button_chooseColor.BackColor = color;

            radioButton2_Center.Checked = true;

            InstalledFontCollection ifc = new InstalledFontCollection();
            fontFamilies = ifc.Families;
            foreach (var font in fontFamilies) comboBox1_FontFamily.Items.Add(font.Name);

            comboBox1_FontFamily.SelectedItem = "Tahoma";

            FormatFont();
        }
        void FormatFont()
        {
            myFontStyle = FontStyle.Regular;
            if (checkBox1_Bold.Checked) myFontStyle = myFontStyle | FontStyle.Bold;
            if (checkBox2_Italic.Checked) myFontStyle = myFontStyle | FontStyle.Italic;
            if (checkBox3_Underline.Checked) myFontStyle = myFontStyle | FontStyle.Underline;

            string font = comboBox1_FontFamily.Text;
            int size = Convert.ToInt32(comboBox2_SizeBox.Text);
            richTextBox1_Preview.Font = new Font(font, size, myFontStyle);

            if (radioButton1_Left.Checked) richTextBox1_Preview.SelectionAlignment = HorizontalAlignment.Left;
            if (radioButton2_Center.Checked) richTextBox1_Preview.SelectionAlignment = HorizontalAlignment.Center;
            if (radioButton3_Right.Checked) richTextBox1_Preview.SelectionAlignment = HorizontalAlignment.Right;

        }
        private void button_chooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                button_chooseColor.BackColor = colorDlg.Color;
                richTextBox1_Preview.ForeColor = colorDlg.Color;
            }
        }

        private void comboBox1_FontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatFont();
        }

        private void checkBox1_Bold_CheckedChanged(object sender, EventArgs e)
        {
            FormatFont();
        }

        private void checkBox2_Italic_CheckedChanged(object sender, EventArgs e)
        {
            FormatFont();
        }

        private void checkBox3_Underline_CheckedChanged(object sender, EventArgs e)
        {
            FormatFont();
        }

        private void radioButton1_Left_CheckedChanged(object sender, EventArgs e)
        {
            FormatFont();
        }

        private void radioButton2_Center_CheckedChanged(object sender, EventArgs e)
        {
            FormatFont();
        }

        private void radioButton3_Right_CheckedChanged(object sender, EventArgs e)
        {
            FormatFont();
        }

        private void comboBox2_SizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatFont();
        }
    }
}
