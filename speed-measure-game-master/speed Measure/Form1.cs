using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speed_Measure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Splash.Width = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Splash.Width += 10;
            if (Splash.Width >= 600)
            {
                timer1.Stop();
                new Home().Show();
                Visible = false;
            }
        }
    }
}
