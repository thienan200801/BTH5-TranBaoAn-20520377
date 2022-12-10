using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai07
{
    public partial class Form1 : Form
    {
        Timer myTime = new Timer();
        public Form1()
        {
            InitializeComponent();
            myTime.Tick += timer1_Tick_1;
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            myTime.Interval = 1000;
            myTime.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
