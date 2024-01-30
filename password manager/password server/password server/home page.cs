using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add sql databse 
using System.Data.Sql;
using System.Data.SqlClient;

namespace password_server
{
    public partial class home_page : Form
    {
        // Database connection string 
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\password server\password server\password server\password info.mdf;Integrated Security=True";
        
        public home_page()
        {
            InitializeComponent();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void headr_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("INSERT INTO password_info (password_id, password_name,update_date,password) VALUES (@pid, @pname,@udate,@password)", con);
                mycmd.Parameters.AddWithValue("@pid", txt_Pid.Text);
                mycmd.Parameters.AddWithValue("@pname", txt_Pname.Text);
                mycmd.Parameters.AddWithValue("@udate", date.Value);
                mycmd.Parameters.AddWithValue("@password", txt_p.Text);
                mycmd.ExecuteNonQuery();
                con.Close();
                // Display success message
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ee)
            {
                // Display error message
                MessageBox.Show("Error: " + ee.Message);
            }
        }

        private void BTNlogout_Click(object sender, EventArgs e)
        {
            //exit button 
            var result = MessageBox.Show("Are you shour do you wantto Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTNlogout_MouseLeave(object sender, EventArgs e)
        {
            {
                // Change the button color on mouse leave
                BTNlogout.BackColor = Color.White;
            } 
        }

        private void BTNlogout_MouseHover(object sender, EventArgs e)
        {
            {
                // Change the button color on mouse hover
                BTNlogout.BackColor = Color.Red;
            } 
        }

        private void home_page_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("UPDATE password_info SET password_name=@password_name,update_date=@update_date,password=@password WHERE password_id=@pid;", con);
                mycmd.Parameters.AddWithValue("@pid", txt_Pid.Text);
                mycmd.Parameters.AddWithValue("@pname", txt_Pname.Text);
                mycmd.Parameters.AddWithValue("@udate", date.Value);
                mycmd.Parameters.AddWithValue("@password", txt_p.Text);
                mycmd.ExecuteNonQuery();
                con.Close();
                // Display success message
                MessageBox.Show("Your Entered Data has been Updated");
            }
            catch (Exception ee)
            {
                // Display error message if an exception occurs
                MessageBox.Show("Error: " + ee.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("Select * From password_info", con);
                SqlDataAdapter ad = new SqlDataAdapter(mycmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ee)
            {
                // Display error message
                MessageBox.Show("Invalid");
            }
        }
        
    }
}
