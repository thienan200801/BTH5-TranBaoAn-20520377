using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai03
{
    public partial class Form1 : Form
    {
        Rectangle mRect;

        int currentR = 500;
        int currentX = 0;
        int currentY = 0;


        Graphics g;

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            deleteOldCircle();
            int x = e.X;
            int y = e.Y;
            this.currentX = x;
            this.currentY = y;
            handleDrawCircle();
        }

        private void handleDrawCircle()
        {

            g = this.CreateGraphics();
            Rectangle rectangle = new Rectangle();
            PaintEventArgs arg = new PaintEventArgs(g, rectangle);
            DrawCircle(arg, currentX, currentY, currentR, currentR);
        }

        private void deleteOldCircle()
        {
            int x = currentX;
            int y = currentY;
            int height = currentR;
            int width = currentR;
            g = this.CreateGraphics();
            Rectangle rectangle = new Rectangle();
            PaintEventArgs arg = new PaintEventArgs(g, rectangle);
            Pen pen = new Pen(this.BackColor, 3);
            arg.Graphics.DrawEllipse(pen, x - width / 2, y - height / 2, width, height);
        }

        private void DrawCircle(PaintEventArgs e, int x, int y, int width, int height)
        {
            Pen pen = new Pen(Color.Red, 3);
            e.Graphics.DrawEllipse(pen, x - width / 2, y - height / 2, width, height);
        }



        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                deleteOldCircle();
                currentR--;
                handleDrawCircle();
            }

            if (e.KeyCode == Keys.Up)
            {
                deleteOldCircle();
                currentR++;
                handleDrawCircle();
            }



        }
    }
}



