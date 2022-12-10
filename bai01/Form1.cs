using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HandleMove(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    label1.Location = new Point(label1.Location.X, label1.Location.Y - 1);
                    break;
                case Keys.Down:
                    label1.Location = new Point(label1.Location.X, label1.Location.Y + 1);
                    break;
                case Keys.Right:
                    label1.Location = new Point(label1.Location.X + 1, label1.Location.Y);
                    break;
                case Keys.Left:
                    label1.Location = new Point(label1.Location.X - 1, label1.Location.Y);
                    break;
            }
        }

    }
}
