using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "kobie" && tb2.Text == "1234")
            {
                welcome w = new welcome();
                this.Hide();
                w.ShowDialog();
                this.Close();
            }
            else if (tb1.Text == "")
            {
                button1.Enabled = false;
            }

            else
            {
                MessageBox.Show("Username or Password is Incorrect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (tb2.Text == "")
            {
                button1.Enabled = true;
            }
            else if (tb1.Text == "")
                button1.Enabled = false;
        }
    }
}
