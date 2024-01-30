using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private int incorrectAttempts = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //login Button 
            if (Txtuser.Text == "Admin" && Txtpassword.Text == "123")
            {
                // Correct credentials
                login_btn.BackColor = Color.Green;
                home_page frm = new home_page();
                frm.Show();
                this.Hide();
            }
            else
            {
                // Incorrect credentials
                incorrectAttempts++;

                if (incorrectAttempts >= 5) //Exit 
                {
                    MessageBox.Show("Too many incorrect attempts. The application will now exit.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    login_btn.BackColor = Color.Red; 
                    MessageBox.Show("Incorrect Password. Please try again. Attempts left: {5 - incorrectAttempts}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void check_show_pass_CheckedChanged(object sender, EventArgs e)
        {
            Txtpassword.PasswordChar = check_show_pass.Checked ? '\0' : '*'; 
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            {
                // Change the button color on mouse hover
                BTNlogout.BackColor = Color.Red;
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
    }
}
