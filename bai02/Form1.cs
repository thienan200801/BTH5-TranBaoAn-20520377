using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai02
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Rectangle rect;

        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 800;
        }

        private void DrawRectangle(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            rect = new Rectangle(350, 350, 50, 50);
            e.Graphics.DrawRectangle(blackPen, rect);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             switch (e.KeyCode)
                {
                    case Keys.Up:
                    rect.Location = new Point(rect.Location.X, rect.Location.Y - 1);
                        break;
                    case Keys.Down:
                    rect.Location = new Point(rect.Location.X, rect.Location.Y + 1);
                        break;
                    case Keys.Right:
                    rect.Location = new Point(rect.Location.X + 1, rect.Location.Y);
                        break;
                    case Keys.Left:
                    rect.Location = new Point(rect.Location.X - 1, rect.Location.Y);
                        break;
                }
            
        }
    }
}
