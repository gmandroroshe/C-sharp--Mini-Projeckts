using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celsius_and_Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox2.Text); 

            double ans = (x*9/5)+35;

            textBox1.Text = ans.ToString();
            
            //Integer -- > String 
        }
    }
}
