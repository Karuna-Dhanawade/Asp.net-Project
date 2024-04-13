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
    public partial class TeacherDetails : Form
    {
        public TeacherDetails()
        {
            InitializeComponent();
        }

        private void TeacherDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.TEACHER_DETAILS' table. You can move, or remove it, as needed.
            this.tEACHER_DETAILSTableAdapter.Fill(this.dataSet2.TEACHER_DETAILS);

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
                cmd.CommandText = "insert into Teacher_Details(T_Name,Address,ContactNo,Gender,Emailid,Subject,Qualification,Payment)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + (radioButton1.Checked ? "Male" : "Female") + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
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
                cmd.CommandText = "select * from Teacher_Details";
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
                cmd.CommandText = "update Teacher_Details set Payment='" + textBox7.Text + "' where T_Name='" + textBox1.Text + "'";
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
                cmd.CommandText = "delete from Teacher_Details where T_Name='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                DisplayData();
                MessageBox.Show("Record deleted successfully.");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string insertquery = "select * from Teacher_Details where T_name='" + textBox1.Text + "%'";
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
                DisplayD();
                orada.Update(dataTable);

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch(OracleException ex1)
            {
                 MessageBox.Show("Error: " + ex1.Message);
            }
            finally
            {
                 cmd.Dispose();
                cnn.Dispose();
            }
        }

        private void DisplayD()
        {
            try
            {
                string con = "Data source=XE;user id=Karuna;Password=karuna123";

                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "select * from Teacher_Details where T_name='" + textBox1.Text + "'";
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
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int n = 10;
                if (textBox3.Text.Length < n)
                {

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    MessageBox.Show("Enter only 10 Digits.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    errorProvider1.SetError(textBox1, "Teacher Name are required.");
                }
                else
                {
                    errorProvider1.SetError(textBox1, string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TeacherReports t = new TeacherReports();
            t.Show();
        }


    }
}
