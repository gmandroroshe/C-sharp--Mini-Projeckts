using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_manegment_system
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //for EXIT 
            Application.Exit();
        }

        private void Formmain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_detels frm = new Employee_detels();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Salary frm = new Form_Salary();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Leaves frm = new Form_Leaves();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Monthly_Salary frm = new Form_Monthly_Salary();
            frm.Show();
            this.Hide();
        }

        private void form1(object sender, EventArgs e)
        {

        }
    }
}
