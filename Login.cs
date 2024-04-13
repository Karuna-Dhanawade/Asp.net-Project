using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coaching_Classes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "Karuna") & (textBox2.Text == "K123"))
                {

                    MessageBox.Show("Login successfully.");
                    Frantpage f = new Frantpage();
                    f.Show();

                }
                else if ((textBox1.Text != "Karuna") & (textBox2.Text == "K123"))
                {
                    MessageBox.Show("Invalid Username");
                }
                else if ((textBox1.Text == "Karuna") & (textBox2.Text != "K123"))
                {
                    MessageBox.Show("Invalid Password");
                }
                else if ((textBox1.Text != "Karuna") & (textBox2.Text != "K123"))
                {
                    MessageBox.Show("Invalid Username & Password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
