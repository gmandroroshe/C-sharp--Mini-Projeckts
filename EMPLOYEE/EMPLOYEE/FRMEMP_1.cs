using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMPLOYEE
{
    public partial class FRMEMP_1 : Form
    {
        public FRMEMP_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMDEP_2 frm = new FRMDEP_2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_from_3 frm = new Employee_from_3();
            frm.Show();
            this.Hide();
        }

        private void FRMEMP_1_Resize(object sender, EventArgs e)
        {
            button1.Left = (this.Size.Width - button1.Size.Width) / 2;
        }
    }
}
