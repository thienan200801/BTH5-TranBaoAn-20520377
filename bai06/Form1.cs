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

namespace bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FontFamily[] fontFamilies;
        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection ifc = new InstalledFontCollection();
            fontFamilies = ifc.Families;
            foreach (var font in fontFamilies) comboBox1.Items.Add(font.Name);
        }
    }
}
