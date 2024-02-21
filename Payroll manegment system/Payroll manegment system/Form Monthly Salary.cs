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
    public partial class Form_Monthly_Salary : Form
    {
        //ADD database connection 
        // database properties - connection string copy and past 
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\Unit_01PRO - Programming\C# Projeckts\Skills International\Payroll manegment system\Payroll manegment system\manegment system database.mdf;Integrated Security=True";


        //VARYABLS
        double totalnumberofdays = 0;
        double otrate = 0;
        double othours = 0;
        double otamount = 0;
        double basicsalary = 0;
        double noofabsentdays = 0;
        double nopayvalue = 0;
        double allowance = 0;
        double govermenttaxrate = 0;

        double totaleallowance = 0;
        double taxamonunt = 0;
        double totaldeduction = 0;
        double nepay = 0; 

        public void calculate()
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();

                SqlCommand mycmd = new SqlCommand("SELECT nodays,taxrate FROM salcycle WHERE year=@year and month=@month", con);
                mycmd.Parameters.AddWithValue("@year", comboBox1.SelectedItem.ToString ());
                mycmd.Parameters.AddWithValue("@month", comboBox2.SelectedItem.ToString());
                SqlDataReader r = mycmd.ExecuteReader();

                while (r.Read())
                {
                    totalnumberofdays = double.Parse(r["nodays"].ToString());
                    govermenttaxrate = double.Parse(r["taxrate"].ToString());
                }

                con.Close();

                //EMPLOYEE DETAILS

                con.Open();

                mycmd = new SqlCommand("SELECT bsal,otrate,allowance FROM employee WHERE eid=@eid", con);
                mycmd.Parameters.AddWithValue("@eid", comboBox3.SelectedItem.ToString());
                r = mycmd.ExecuteReader();

                while (r.Read())
                {
                    basicsalary = double.Parse(r["bsal"].ToString());
                    allowance = double.Parse(r["allowance"].ToString());
                    otrate = double.Parse(r["otrate"].ToString());
                }

                con.Close();

                //CALCULATION 

                othours = double.Parse(textBox1.Text);
                otamount = Math.Round(otrate * othours, 2);

                noofabsentdays = double.Parse(textBox3.Text);
                nopayvalue = Math.Round((basicsalary / totalnumberofdays) * noofabsentdays, 2 );

                totaleallowance = basicsalary + allowance + otamount;


                taxamonunt = Math.Round(totaleallowance * govermenttaxrate / 100,2);
                totaldeduction = nopayvalue + taxamonunt;

                nepay = totaleallowance - totaldeduction;


                label2.Text = nepay.ToString();
                MessageBox.Show("Net Salary" + nepay.ToString());

            }
                catch
            {
                MessageBox.Show("Error");
            }


            
        }

        public Form_Monthly_Salary()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Monthly_Salary_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();

                SqlCommand mycmd = new SqlCommand("SELECT year FROM salarycycle ", con);
                SqlDataReader r = mycmd.ExecuteReader();

                while(r.Read())
                {
                    comboBox1.Items.Add(r["year"].ToString());

                }

                con.Close();

                con.Open();

                mycmd = new SqlCommand("SELECT eid FROM employee ", con);

                r = mycmd.ExecuteReader();
                 
                while (r.Read())
                {
                    comboBox3.Items.Add(r["eid"].ToString());
                }

                con.Close();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formmain frm = new Formmain();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Import Button 
            calculate();

            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();

                SqlCommand mycmd = new SqlCommand("INSERT INTO salary (year,month,eid,otrate,abdays,netsal) VALUES (@year,@month,@eid,@otrate,@abdays,@netsal) ", con);
                mycmd.Parameters.AddWithValue("@year", comboBox1.SelectedItem.ToString());
                mycmd.Parameters.AddWithValue("@month", comboBox2.SelectedItem.ToString());
                mycmd.Parameters.AddWithValue("@eid", comboBox3.SelectedItem.ToString());
                mycmd.Parameters.AddWithValue("@otrate", textBox1.Text);
                mycmd.Parameters.AddWithValue("@abdays", textBox3.Text);
                mycmd.Parameters.AddWithValue("@netsal", label1.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Completed");



            }
            catch
            {
                MessageBox.Show("Error");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();

                SqlConnection con = new SqlConnection(con_string);
                con.Open();

                SqlCommand mycmd = new SqlCommand("SELECT month FROM salcycale WHERE year=@year ", con);
                mycmd.Parameters.AddWithValue("@year", comboBox1.SelectedItem.ToString());
                SqlDataReader r = mycmd.ExecuteReader();

                while (r.Read())
                {
                    comboBox2.Items.Add(r["month"].ToString());

                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Updete Button 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
