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

namespace Student_system
{
    public partial class Form1 : Form
    {
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\Unit_01PRO - Programming\C# Projeckts\Student system\Student system\Student.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();

                SqlCommand mycmd = new SqlCommand("Updete student set name=@name,age=@age,addres=@addres WHERE studentid=@studentid", con);
                mycmd.Parameters.AddWithValue("@studentid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@age", textBox3.Text);
                mycmd.Parameters.AddWithValue("@addres", textBox4.Text);

                

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
            
        }
    }
}
