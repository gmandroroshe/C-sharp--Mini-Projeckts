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
    public partial class Employee_detels : Form
    {
        //ADD database connection 
        // database properties - connection string copy and past 
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\Unit_01PRO - Programming\C# Projeckts\Skills International\Payroll manegment system\Payroll manegment system\manegment system database.mdf;Integrated Security=True";

        public Employee_detels()
        {
            InitializeComponent();
        }

        private void Employee_detels_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formmain frm = new Formmain();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERT TABLE CREATE 
            // EMPLOYEE DATA 
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("insert into employee(eid,name,address,dob,bsal,allowance,otrate) values(@eid,@name,@address,@dob,@bsal,@allowance,@otrate)", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@address", textBox3.Text);
                mycmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                mycmd.Parameters.AddWithValue("@bsal", textBox4.Text);
                mycmd.Parameters.AddWithValue("@otrate", textBox5.Text);
                mycmd.Parameters.AddWithValue("@allowance", textBox6.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UPDETE EMPLOYEE TABLE 
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("UPDATE employee  SET  name=@name, address=@address,dob=@dob,bsal=@bsal,otrate=@otrate,allowance=@allowance WHERE eid=@eid;", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@address", textBox3.Text);
                mycmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                mycmd.Parameters.AddWithValue("@bsal", textBox4.Text);
                mycmd.Parameters.AddWithValue("@otrate", textBox5.Text);
                mycmd.Parameters.AddWithValue("@allowance", textBox6.Text);
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
            //DELETE DEPARTMENT DELATILS 
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("DELETE FROM employee WHERE eid=@eid;", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@address", textBox3.Text);
                mycmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                mycmd.Parameters.AddWithValue("@bsal", textBox4.Text);
                mycmd.Parameters.AddWithValue("@otrate", textBox5.Text);
                mycmd.Parameters.AddWithValue("@allowance", textBox6.Text);
                mycmd.ExecuteNonQuery();
                con.Close();
                //create delate message
                MessageBox.Show("DELTED");

            }
            catch (Exception ee)
            {
                //error messege
                MessageBox.Show("Error");

            }
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
