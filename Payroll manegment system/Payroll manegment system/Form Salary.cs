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

    public partial class Form_Salary : Form
    {
        //ADD database connection 
        // database properties - connection string copy and past 
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\Unit_01PRO - Programming\C# Projeckts\Skills International\Payroll manegment system\Payroll manegment system\manegment system database.mdf;Integrated Security=True";

        public Form_Salary()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formmain frm = new Formmain();
            frm.Show();
            this.Hide();
        }

        private void Form_Salary_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int nodays = (int)(dateTimePicker1.Value - dateTimePicker2.Value).TotalDays;

                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("Insert INTO salarycycle(year,month,salcyclestart,salcycleend,nodays,taxrate) VALUES (year=@year,month=@month,salcyclestart=@salcyclestart,salcycleend=@salcycleend,nodays=@nodays,tacrate=@tacrate);", con);
                mycmd.Parameters.AddWithValue("year", textBox1.Text);
                mycmd.Parameters.AddWithValue("month", textBox2.Text);
                mycmd.Parameters.AddWithValue("salCycleStart", dateTimePicker1.Value.Date);
                mycmd.Parameters.AddWithValue("salCycleend", dateTimePicker2.Value.Date);
                mycmd.Parameters.AddWithValue("noDays", nodays);
                mycmd.Parameters.AddWithValue("taxRate", textBox4.Text);
                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deta Inserted Completed");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

