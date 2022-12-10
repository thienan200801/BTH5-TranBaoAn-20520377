using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai03
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        Pen blackPen = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(600, 600);
            g = Graphics.FromImage(bm);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            g.DrawEllipse(blackPen, e.X, e.Y, 10, 10);
        }

    }
}
