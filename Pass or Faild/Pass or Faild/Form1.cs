using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_or_Faild
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textBox1.Text);
            if (m >= 50)
            {
                label1.Text = "Pass";
            }
            else
            {
                label1.Text = "Faild";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
