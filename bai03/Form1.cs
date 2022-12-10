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
        Rectangle mRect;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mRect = new Rectangle(e.X, e.Y, 0, 0);
            this.Invalidate();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mRect = new Rectangle(mRect.Left, mRect.Top, e.X - mRect.Left, e.Y - mRect.Top);
                this.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, mRect);
            }
        }
    }
}
