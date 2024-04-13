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
    public partial class CourseDetails : Form
    {
        public CourseDetails()
        {
            InitializeComponent();
        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.COURSEM' table. You can move, or remove it, as needed.
            this.cOURSEMTableAdapter.Fill(this.dataSet1.COURSEM);

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
                cmd.CommandText = "insert into courseM(c_id,cname,subject,fees,Time_Duration)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')";
                cmd.ExecuteNonQuery();
                DisplayData();
                MessageBox.Show("Save Successfully.");
                cnn.Close();
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
                cmd.CommandText = "select * from courseM";
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Data source=XE;user id=Karuna;Password=karuna123";

                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "update courseM set fees='" + textBox4.Text + "'where subject='" + textBox3.Text + "'";
                cmd.ExecuteNonQuery();
                DisplayData();
                MessageBox.Show("Updated successfully.");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Data source=XE;user id=Karuna;Password=karuna123";

                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "delete from courseM where c_id='" + textBox1.Text + "'OR cname='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                DisplayData();
                MessageBox.Show("Deleted successfully.");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string insertquery = "select * from courseM where c_id='" + textBox1.Text + "'OR cname='" + textBox2.Text + "'OR Subject='" + textBox3.Text + "%'";
            string con = "Data source=XE;user id=Karuna;Password=karuna123";
            OracleConnection cnn = new OracleConnection(con);
            cnn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = cnn;
            cmd.CommandText = insertquery;
            try
            {
                OracleDataReader reader = cmd.ExecuteReader();

                OracleDataAdapter orada = new OracleDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                orada.Fill(dataTable);
                dataTable.Load(reader);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataTable;
                dataGridView1.DataSource = bSource;
                Display();
                orada.Update(dataTable);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (OracleException ex1)
            {
                MessageBox.Show("Error: " + ex1.Message);
            }
            finally
            {
                cmd.Dispose();
                cnn.Dispose();
            }
        }
        public void Display()
        {
            try
            {
                string con = "Data source=XE;user id=Karuna;Password=karuna123";

                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "select * from courseM where c_id='" + textBox1.Text + "'OR cname='" + textBox2.Text + "'Or subject='" + textBox3.Text + "'";
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
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
