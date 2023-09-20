using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_calculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a, b; 
            try 
            {
                lblSinal.Text = "+";

                a = double.Parse(txtN1.Text);
                b = Convert.ToDouble(txtN2.Text);



                lblResultado.Text = (a + b).ToString();
                }
       

            catch (FormatException)
                {
                    lblResultado.Text = "não foi possivel realizar a operação";
                }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "";

            txtN1.Focus();

        }



        private void Button4_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {

                lblSinal.Text = "-";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = (a - b).ToString();
                    // p = math.Pow(a, b);
            }

            catch (FormatException)
            {
                lblResultado.Text = "não foi possivel realizar a operação";
            }
                
            }


        private void Button5_Click(object sender, EventArgs e)
        {
            double a, b;

            try
            {
                lblSinal.Text = "÷";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                if (b == 0)
                {
                    lblResultado.Text = "não foi possivel realizar a operação";
                }
                else
                {
                    lblResultado.Text = (a / b).ToString();
                }

            }

            catch(FormatException)
            {
                lblResultado.Text = "não foi possivel realizar a operação";  
            }

            // catch (DivideByZeroException)
            // { }


        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                lblSinal.Text = "x";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                lblResultado.Text = "não foi possivel realizar a operação";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                lblSinal.Text = "^";
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = Math.Pow(a, b).ToString();
            }
            catch (FormatException)
            {
                lblResultado.Text = "não foi possivel realizar a operação";
            }
        }
    }
}
