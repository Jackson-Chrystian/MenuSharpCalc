﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsuario.Text.Equals("rhuan") && txtSenha.Text.Equals("123"))
                {
                    var menu = new FrmMenuMDiNovo();
                    menu.Show();
                    
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usúario ou senha incorretos",
                                     "Desculpe",
                                     MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtSenha.Text = "";
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                                   ex.Message,
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
