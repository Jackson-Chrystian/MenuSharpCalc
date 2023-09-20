using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_calculos
{
    public partial class FrmSuper : Form
    {
        public FrmSuper()
        {
            InitializeComponent();
        }

        string vOperacao;
        decimal vNumAnt;
        bool vlimpar = false;

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text); 
            switch (vOperacao)
            {
                case "+":
                    {
                        lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                        break;
                    }
                case "-":
                    {
                        lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                        break;
                    }
                case "*":
                    {
                        lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                        break;
                    }
                case "/":
                    {
                        lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                        break;
                    }

            }
            lblVisor.Focus();
        } 

            private void btnNumero(object sender, EventArgs e)
       {
            string vNumero = ((Button)sender).Text;
            //Limpa o visor após operação 
            if (vlimpar)
            {
                lblVisor.Text = "";
                vlimpar = false; 
            }
            //limpa o visor se apenas "0"
            if (lblVisor.Text == "0") lblVisor.Text = "";
            if ((vNumero == "," && !lblVisor.Text.Contains(",")) || vNumero != ",")
            {
                lblVisor.Text += vNumero; // contatena o número ao lblVisor 
            }

            lblVisor.Focus();
        }

        private void btnOperacao(object sender, EventArgs e)
        {
            vOperacao = ((Button)sender).Text;
            vNumAnt = decimal.Parse(lblVisor.Text);
            vlimpar = true;
            lblVisor.Text += vOperacao;
            lblVisor.Focus();
        }


        private void FrmSuper_KeyDown(object sender, KeyEventArgs e)
        {
            Button bot = new Button ();
            if (e.Control==true) //se control for pressionado. 
            {

            }
            if (e.Shift == true)
            {

            }
            if (e.Alt == true)
            {

            }
            label1.Text = e.KeyCode.ToString();

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))// ||// ((e.KeyCode>=Keys.NumPad0 && e.KeyCode<=Keys.NumPad9))
            {
                bot.Text = e.KeyCode.ToString().Substring(1, 1);
                btnNumero(bot, e);
                return;

            }

            else if ((e.KeyCode == Keys.Oemcomma))
            {
                bot.Text = ",";
                btnNumero(bot, e);
                return;

            }
            
            switch(e.KeyCode.ToString()) 
            {
                case "Add": // case "add"
                    {
                        bot.Text = "+";
                        btnOperacao(bot, e);
                        return;
                    }
                case "Subtract": // 
                    {
                        bot.Text = "-";
                        btnOperacao(bot, e);
                        return;
                    }

                case "Multiply": // case "add"
                    {
                        bot.Text = "x";
                        btnOperacao(bot, e);
                        return;

                    }

                case "Divide":
                    {
                        bot.Text = "/";
                        btnOperacao(bot, e); 
                        return;
                    }
            }
            if(e.KeyCode==Keys.Enter)
            {
               btnIgual_Click (bot, e);
            }
            if (e.KeyCode == Keys.Back)
            {
                btnBack_Click(bot, e);
            }

         

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if (lblVisor.Text=="")
            {
                lblVisor.Text = "0";

            }
        }


        private void btnInvertSinal_Click(object sender, EventArgs e)
        {
            lblVisor.Text = (decimal.Parse(lblVisor.Text) * -1).ToString();
        }

        private void btnSair_Click (object sender, EventArgs e)
        {
            Close();
        }
    }
}
