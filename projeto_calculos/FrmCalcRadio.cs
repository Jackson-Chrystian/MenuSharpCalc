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
    public partial class FrmCalcRadio : Form
    {
        public FrmCalcRadio()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "+";
         }

        private void Subtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "-"; 
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "x";
        }

        private void Dividir_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "/";
        }

        private void Potenciacao_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "x²";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp;

            num1 = Convert.ToDouble(N1.Text);
            num2 = Convert.ToDouble(N2.Text);

            if (lblSinal.Text == "+")
            {

                resp = num1 + num2;
                lblResultado.Text = resp.ToString();
            }
            else if (lblSinal.Text == "-") {

                resp = num1 - num2;
                lblResultado.Text = resp.ToString();
            }

            else if (lblSinal.Text == "x")
            {

                resp = num1 * num2;
                lblResultado.Text = resp.ToString();
            }

            else if (lblSinal.Text == "÷")
            {

                resp = num1 / num2;
                lblResultado.Text = resp.ToString();
            }

            else if (lblSinal.Text == "x²")
            {
               
                resp = Math.Pow(num1,num2);
                lblResultado.Text = resp.ToString();
            }

            else
            {
                if (N2.Text == " ") 
                {
                    lblSinal.Text = "√";
                    resp = Math.Sqrt(num1);
                    lblResultado.Text = resp.ToString();
                }
                else
                {
                    MessageBox.Show("Raiz quadrada só se faz com um número o BURRO!!");
                }
                
            }

        }

        private void RbRaiz_CheckedChanged(object sender, EventArgs e)
        {
            lblSinal.Text = "√";
        }




        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblSinal.Text = "?";
            N1.Text = "";
            N2.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
