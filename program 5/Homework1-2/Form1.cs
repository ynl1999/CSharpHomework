using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void label3_Click(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
            string a = textBox1.Text;
            string b = textBox2.Text;
            double A = double.Parse(a);
            double B = double.Parse(b);
            double AB = A * B;
            label3.Text = "" + AB;
        }
    }
}
