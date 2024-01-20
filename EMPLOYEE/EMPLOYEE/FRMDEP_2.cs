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
    public partial class FRMDEP_2 : Form
    {
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\Unit_01PRO - Programming\C# Projeckts\EMPLOYEE\EMPLOYEE\department.mdf;Integrated Security=True";
        public FRMDEP_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRMDEP_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            FRMEMP_1 frm = new FRMEMP_1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con=new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd=new SqlCommand("INSERT INTO department(depid,depname) VALUES (@depid, @depname)",con);
                mycmd.Parameters.AddWithValue("@depid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@depname", textBox2.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

            }
            catch(Exception ee)
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
                SqlCommand mycmd = new SqlCommand("SELECT * FROM department", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("UPDATE department SET depname=@depname  WHERE depid=@depid ", con);
                mycmd.Parameters.AddWithValue("@depid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@depname", textBox2.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updeted");
                

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
                mycmd.Parameters.AddWithValue("@depid", textBox1.Text);


                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("SELECT * FROM department WHERE depid=@depid", con);
                mycmd.Parameters.AddWithValue("depid ", comboBox1.SelectedItem.ToString());

                SqlDataReader r = mycmd.ExecuteReader();

                while (r.Read())
                {
                    textBox1.Text = r["depid"].ToString();
                    textBox2.Text = r["depname"].ToString();
                }

                con.Close();
            }
            catch (Exception ee)
            {

            }
        }
    }
}
