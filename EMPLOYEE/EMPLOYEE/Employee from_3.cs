using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EMPLOYEE
{
    public partial class Employee_from_3 : Form
    {
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\Unit_01PRO - Programming\C# Projeckts\EMPLOYEE\EMPLOYEE\department.mdf;Integrated Security=True";
        public Employee_from_3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("INSERT INTO employee(eid,name,salary,address) VALUES (@eid,@name,@salary,@address)", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@salary", textBox3.Text);
                
                mycmd.Parameters.AddWithValue("@address", textBox5.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void Employee_from_3_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("SELECT depid FROM department", con);

                SqlDataReader r = mycmd.ExecuteReader();

                while (r.Read())
                {
                    comboBox1.Items.Add(r["depid"].ToString());
                }

                con.Close();
            }
            catch (Exception ee)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("UPDATE department SET depname=@depname  WHERE depid=@depid ", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@salary", textBox3.Text);

                mycmd.Parameters.AddWithValue("@address", textBox5.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("DELETE FROM department WHERE depid=@depid ", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@salary", textBox3.Text);

                mycmd.Parameters.AddWithValue("@address", textBox5.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("SELECT * FROM employee", con);
                SqlDataAdapter ad = new SqlDataAdapter(mycmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();


            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRMEMP_1 frm = new FRMEMP_1();
            frm.Show();
            this.Hide();
        }
    }
}
