using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add sql 
using System.Data.Sql;
using System.Data.SqlClient;

namespace Payroll_manegment_system
{
    public partial class Form_Leaves : Form
    {
        //ADD database connection 
        // database properties - connection string copy and past 
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\Unit_01PRO - Programming\C# Projeckts\Skills International\Payroll manegment system\Payroll manegment system\manegment system database.mdf;Integrated Security=True";

        public Form_Leaves()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formmain frm = new Formmain();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("INSERT INTO lelaves (year,leaves)VALUES (@year,@leaves);", con);
                mycmd.Parameters.AddWithValue("@year", textBox1.Text);
                mycmd.Parameters.AddWithValue("@leaves", textBox3.Text);

         

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

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
                SqlCommand mycmd = new SqlCommand("UPDATE lelaves SET year=@year,leaves=@leaves  WHERE year=@year;", con);
                mycmd.Parameters.AddWithValue("@year", textBox1.Text);
                mycmd.Parameters.AddWithValue("@leaves", textBox3.Text);



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
                SqlCommand mycmd = new SqlCommand("DELETE FROM lelaves WHERE year=@year;", con);
                mycmd.Parameters.AddWithValue("@year", textBox1.Text);
                mycmd.Parameters.AddWithValue("@leaves", textBox3.Text);



                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("SELECT * FROM lelaves", con);
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
    }
}
