using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Configuration;

namespace Coaching_Classes
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
            
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dataSet5.COURSEM' table. You can move, or remove it, as needed.
                this.cOURSEMTableAdapter1.Fill(this.dataSet5.COURSEM);
                // TODO: This line of code loads data into the 'dataSet4.COURSEM' table. You can move, or remove it, as needed.
                this.cOURSEMTableAdapter.Fill(this.dataSet4.COURSEM);
                // TODO: This line of code loads data into the 'dataSet3.STUDENT' table. You can move, or remove it, as needed.
                this.sTUDENTTableAdapter.Fill(this.dataSet3.STUDENT);
                string con = "Data source=XE;user id=Karuna;Password=karuna123";

                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                string oracle = "select cname from courseM";
                cmd = new OracleCommand(oracle, cnn);

                cnn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string con = "Data source=XE;user id=Karuna;Password=karuna123";

            OracleConnection cnn = new OracleConnection(con);
            OracleCommand cmd = new OracleCommand();
            cnn.Open();
            string sqls = "select cname,subject from courseM where cname='" + comboBox1.Text + "'";
            cmd = new OracleCommand(sqls,cnn);
            OracleDataReader odr;
            odr = cmd.ExecuteReader();
            if (odr.HasRows == true)
            {
                while (odr.Read())
                {
                    string cname = odr["cname"].ToString();
                    comboBox1.Text = cname.ToString();

                    string subject = odr["subject"].ToString();
                    comboBox2.Text = subject.ToString();
      

                }
            }
            
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string con = "Data source=XE;user id=Karuna;Password=karuna123";

            OracleConnection cnn = new OracleConnection(con);
            OracleCommand cmd = new OracleCommand();
            cnn.Open();
            string sqls = "select subject,fees from courseM where subject='" + comboBox2.Text + "'";
            cmd = new OracleCommand(sqls, cnn);
            OracleDataReader odr;
            odr = cmd.ExecuteReader();
            if (odr.HasRows == true)
            {
                while (odr.Read())
                {
                    string subject = odr["subject"].ToString();
                    comboBox2.Text = subject.ToString();
                    string fees = odr["fees"].ToString();
                    textBox7.Text = fees.ToString();
                }
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Data source=XE;user id=Karuna;Password=karuna123";

                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "insert into student(sname,DOB,Address,Emailid,Pin,cno,Gender,Course,Subject,sdate,edate,fees,paid,remfees)Values('" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + textBox5.Text + "," + textBox6.Text + ",'" + (radioButton1.Checked ? "Male" : "Female") + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "'," + textBox7.Text + "," + textBox8.Text + "," + textBox9.Text + ")";
                cmd.ExecuteNonQuery();
                DisplayData();
                MessageBox.Show("save successfully");
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
                cmd.CommandText = "select * from Student";
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
                string con = "Data Source=XE;user id=Karuna;password=Karuna123";
                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "Update student set cno='" + textBox6.Text + "' where sname='" + textBox2.Text + "'";
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
            try
            {
                string con = "Data source=XE;user id=Karuna;Password=karuna123";

                OracleConnection cnn = new OracleConnection(con);
                OracleCommand cmd = new OracleCommand();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "delete from student where sname='" + textBox2.Text + "' OR s_id='" + textBox1.Text + "'";
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
            string insertquery = "select * from student where s_id='" + textBox1.Text + "%'";
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
                cmd.CommandText = "select * from Student where s_id='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OracleDataAdapter ad = new OracleDataAdapter(cmd);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                cnn.Close();
            }
            catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.dateTimePicker1.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.dateTimePicker2.Text = "";
                this.dateTimePicker3.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(this.textBox7.Text);
            b = Convert.ToInt32(this.textBox8.Text);
            c = a - b;
            this.textBox9.Text = c.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int n = 10;
                if (textBox6.Text.Length < n)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int n = 6;
                if (textBox5.Text.Length < n)
                {

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    MessageBox.Show("Enter only 6 Digits.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //string con = "Data source=XE;user id=Karuna;Password=karuna123";

            //OracleConnection cnn = new OracleConnection(con);
            //OracleCommand cmd = new OracleCommand();
            //cnn.Open();
            //string sqls = "select fees from courseM where fees='" + textBox7+ "'";
            //cmd = new OracleCommand(sqls, cnn);
            //OracleDataReader odr;
            //odr = cmd.ExecuteReader();
            //if (odr.HasRows == true)
            //{
            //    while (odr.Read())
            //    {
            //        string fees = odr["fees"].ToString();
            //        textBox7.Text = fees.ToString();
            //    }
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentReport sp = new StudentReport();
            sp.Show();
        }
    }
}
