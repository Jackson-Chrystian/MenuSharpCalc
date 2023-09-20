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
    public partial class FrmMenuMDiNovo : Form
    {
        public FrmMenuMDiNovo()
        {
            InitializeComponent();
        }

           private void ComBotõesToolStripMenuItem_Click(object sender, EventArgs e)
          {
          Form1 objCalc = new Form1(); //Inatancia a classe 
          objCalc.MdiParent = this;
          objCalc.Show(); 
          }

        private void calculadoraSuperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuper objCalc = new FrmSuper(); //Inatancia a classe 
            objCalc.MdiParent = this;
            objCalc.Show();
        }

        private void FrmMenuMDiNovo_Load(object sender, EventArgs e)
        {

        }
    }
}
