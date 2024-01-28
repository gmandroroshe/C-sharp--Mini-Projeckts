using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class btn2 : Form
    {
        public btn2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt1.Text);//string -- > Integer 
            int y = int.Parse(txt2.Text);//string -- > Integer 
            int ans = x + y;
            
            txt3.Text = ans.ToString();
            //Integer -- > String 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt1.Text);//string -- > Integer 
            int y = int.Parse(txt2.Text);//string -- > Integer 
            int ans = x - y;

            txt3.Text = ans.ToString();
            //Integer -- > String 
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt1.Text);//string -- > Integer 
            int y = int.Parse(txt2.Text);//string -- > Integer 
            int ans = x * y;

            txt3.Text = ans.ToString();
            //Integer -- > String 
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txt1.Text);//string -- > Integer 
            int y = int.Parse(txt2.Text);//string -- > Integer 
            int ans = x / y;

            txt3.Text = ans.ToString();
            //Integer -- > String 
        }

        private void btn2_Load(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
