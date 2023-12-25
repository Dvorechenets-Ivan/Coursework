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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            UserAdd.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length > 0)
            {
                new GameBoard(comboBox1.Text.ToUpper()).Show();
              //  MessageBox.Show(comboBox1.Text.ToUpper());
            } else
            {
                new GameBoard("PLAYER").Show();
             //   MessageBox.Show("PLAYER");
            }
            Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserAdd.Visible = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAdd.Visible = true;
            txtUser.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserAdd.Visible = true;
            txtUser.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(txtUser.Text.ToUpper());
            comboBox1.Text = txtUser.Text.ToUpper();
            UserAdd.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Items.Add(txtUser.Text.ToUpper());
                UserAdd.Hide();
                comboBox1.Text = txtUser.Text.ToUpper();
            }
        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox1.Text.Length > 0)
                {
                    new GameBoard(comboBox1.Text.ToUpper()).Show();
                }
                else
                {
                    new GameBoard("PLAYER").Show();
                }
                Visible = false;
            }
        }
    }
}
