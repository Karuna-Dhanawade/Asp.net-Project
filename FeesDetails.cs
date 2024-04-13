using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Coaching_Classes
{
    public partial class FeesDetails : Form
    {
        public FeesDetails()
        {
            InitializeComponent();
        }

        private void FeesDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet9.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter1.Fill(this.dataSet9.STUDENT);
            // TODO: This line of code loads data into the 'dataSet8.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dataSet8.STUDENT);
            // TODO: This line of code loads data into the 'dataSet7.FEEDETAILS' table. You can move, or remove it, as needed.
            this.fEEDETAILSTableAdapter.Fill(this.dataSet7.FEEDETAILS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Data Source=XE;user id=Karuna;password=Karuna123";
                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "select * from student where s_id='" + textBox1.Text + "'";
                OracleDataReader read = cmd.ExecuteReader();
                if (read.Read())
                {
                    textBox2.Text = read["sname"].ToString();
                    textBox6.Text = read["course"].ToString();
                    textBox7.Text= read["subject"].ToString();
                    textBox3.Text = read["fees"].ToString();
                    textBox4.Text = read["paid"].ToString();
                    textBox5.Text = read["fees"].ToString();
                    read.Close();
                    cnn.Close();
                }
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayData()
        {
            try
            {
                string con = "Data source=XE;user id=Karuna;Password=karuna123";

                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "select s_id,sname,course,subject,fees,paid,remfees from student";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OracleDataAdapter ad = new OracleDataAdapter(cmd);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Data Source=XE;user id=Karuna;password=Karuna123";
                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "Update student set paid='" + textBox4.Text + "'where s_id='" + textBox1.Text + "'";
                int a, b, c;
                a = Convert.ToInt32(this.textBox3.Text);
                b = Convert.ToInt32(this.textBox4.Text);
                c = a - b;
                this.textBox5.Text = c.ToString();
                cmd.ExecuteNonQuery();
                DisplayData();
                MessageBox.Show("Updated Successfully.");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = Convert.ToInt32(this.textBox3.Text);
                b = Convert.ToInt32(this.textBox4.Text);
                c = a - b;
                this.textBox5.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a, b, c;
                a = Convert.ToInt32(this.textBox3.Text);
                b = Convert.ToInt32(this.textBox4.Text);
                c = a - b;
                this.textBox5.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
                {
                    e.Handled = true;
                    base.OnKeyPress(e);
                    MessageBox.Show("plz Enter characters only");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Plz Enter only digits.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FeesReports1 fr = new FeesReports1();
            fr.Show();
        }
    }
}
