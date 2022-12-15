using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }   
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

         private void button1_Click_1(object sender, EventArgs e)
         {

            Console.WriteLine("Solve the Linear Equation of the third order\n");
             
            //The variables or placeholders to take inputs.
            double x11, x12, x13;
            double x21, x22, x23;
            double x31, x32, x33;
            double constant1, constant2, constant3;

            x11 = Convert.ToDouble(a11.Text);
            x12 = Convert.ToDouble(a12.Text);
            x13 = Convert.ToDouble(a13.Text);
            x21 = Convert.ToDouble(a31.Text);
            x22 = Convert.ToDouble(a32.Text);
            x23 = Convert.ToDouble(a33.Text);
            x31 = Convert.ToDouble(a32.Text);
            x32 = Convert.ToDouble(a33.Text);
            x33 = Convert.ToDouble(a33.Text);

            constant1 = double.Parse(con1.Text);
            constant2 = double.Parse(con2.Text);
            constant3 = double.Parse(con3.Text);

            Console.WriteLine($"{x11} {x12} {x13}");

            //The variables for the determinants.
            double detConstant, detRoot1, detRoot2, detRoot3;

            //solve the constant determinant.
            detConstant = ((x11 * (x22 * x33) - (x32 * x23))) - (x12 * ((x21 * x33) - (x31 * x23))) + (x31 * ((x21 * x32) - (x31 * x22)));

            //solve the constant determinant.
            detRoot1 = ((x12 * (x23 * constant3) - (x33 * constant2))) - (x13 * ((x22 * constant3) - (x32 * constant2))) + (constant1 * ((x22 * x33) - (x32 * x23)));

            //solve the constant determinant.
            detRoot2 = ((x11 * (x23 * constant3) - (x33 * constant2))) - (x13 * ((x22 * constant3) - (x32 * constant2))) + (constant1 * ((x22 * x33) - (x32 * x23)));

            //solve the constant determinant.
            detRoot3 = ((x13 * (x23 * constant3) - (x33 * constant2))) - (x13 * ((x22 * constant3) - (x32 * constant2))) + (constant1 * ((x22 * x33) - (x32 * x23)));

            //The variables for the roots x1 , x2 and x3.
            double Root1, Root2, Root3;
            Root1 = detRoot1 / detConstant;
            Root2 = detRoot2 / detConstant;
            Root3 = detRoot3 / detConstant;

            //The result
            Console.WriteLine($"{detRoot1}\n {detRoot2} \n {detRoot3}");
            Console.WriteLine();
            Console.WriteLine("The root are : {0} and , {1} and {2}", Root1, Root2, Root3);
            string Rooot1 = Convert.ToString(Root1);
            string Rooot2 = Convert.ToString(Root2);
            string Rooot3 = Convert.ToString(Root3);

            labe1.Text = String.Format($"The root are : \n {Rooot1}\n {Rooot2}\n {Rooot3}");
         }

        private void label17_Click(object sender, EventArgs e)
        {
       
        }
    }
}
