namespace projeto_calculos
{
    partial class FrmCalcRadio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Potenciacao = new System.Windows.Forms.RadioButton();
            this.Dividir = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Subtrair = new System.Windows.Forms.RadioButton();
            this.Somar = new System.Windows.Forms.RadioButton();
            this.N1 = new System.Windows.Forms.TextBox();
            this.N2 = new System.Windows.Forms.TextBox();
            this.lblIgual = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbRaiz = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRaiz);
            this.groupBox1.Controls.Add(this.Potenciacao);
            this.groupBox1.Controls.Add(this.Dividir);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.Subtrair);
            this.groupBox1.Controls.Add(this.Somar);
            this.groupBox1.Location = new System.Drawing.Point(46, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(158, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // Potenciacao
            // 
            this.Potenciacao.AutoSize = true;
            this.Potenciacao.Location = new System.Drawing.Point(4, 97);
            this.Potenciacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Potenciacao.Name = "Potenciacao";
            this.Potenciacao.Size = new System.Drawing.Size(85, 17);
            this.Potenciacao.TabIndex = 4;
            this.Potenciacao.TabStop = true;
            this.Potenciacao.Text = "Potenciacao";
            this.Potenciacao.UseVisualStyleBackColor = true;
            this.Potenciacao.CheckedChanged += new System.EventHandler(this.Potenciacao_CheckedChanged);
            // 
            // Dividir
            // 
            this.Dividir.AutoSize = true;
            this.Dividir.Location = new System.Drawing.Point(4, 76);
            this.Dividir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(52, 17);
            this.Dividir.TabIndex = 3;
            this.Dividir.TabStop = true;
            this.Dividir.Text = "Dividr";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.CheckedChanged += new System.EventHandler(this.Dividir_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 57);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Multiplicar";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // Subtrair
            // 
            this.Subtrair.AutoSize = true;
            this.Subtrair.Location = new System.Drawing.Point(4, 37);
            this.Subtrair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(61, 17);
            this.Subtrair.TabIndex = 1;
            this.Subtrair.TabStop = true;
            this.Subtrair.Text = "Subtrair";
            this.Subtrair.UseVisualStyleBackColor = true;
            this.Subtrair.CheckedChanged += new System.EventHandler(this.Subtrair_CheckedChanged);
            // 
            // Somar
            // 
            this.Somar.AutoSize = true;
            this.Somar.Location = new System.Drawing.Point(4, 17);
            this.Somar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Somar.Name = "Somar";
            this.Somar.Size = new System.Drawing.Size(55, 17);
            this.Somar.TabIndex = 0;
            this.Somar.TabStop = true;
            this.Somar.Text = "Somar";
            this.Somar.UseVisualStyleBackColor = true;
            this.Somar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(224, 94);
            this.N1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(68, 20);
            this.N1.TabIndex = 1;
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(339, 94);
            this.N2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(68, 20);
            this.N2.TabIndex = 2;
            // 
            // lblIgual
            // 
            this.lblIgual.AutoSize = true;
            this.lblIgual.Location = new System.Drawing.Point(417, 96);
            this.lblIgual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIgual.Name = "lblIgual";
            this.lblIgual.Size = new System.Drawing.Size(13, 13);
            this.lblIgual.TabIndex = 4;
            this.lblIgual.Text = "=";
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(306, 95);
            this.lblSinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(18, 18);
            this.lblSinal.TabIndex = 5;
            this.lblSinal.Text = "?";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(224, 155);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(60, 20);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(339, 155);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(57, 20);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(453, 156);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 19);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(442, 96);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(106, 18);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbRaiz
            // 
            this.rbRaiz.AutoSize = true;
            this.rbRaiz.Location = new System.Drawing.Point(4, 118);
            this.rbRaiz.Margin = new System.Windows.Forms.Padding(2);
            this.rbRaiz.Name = "rbRaiz";
            this.rbRaiz.Size = new System.Drawing.Size(96, 17);
            this.rbRaiz.TabIndex = 5;
            this.rbRaiz.TabStop = true;
            this.rbRaiz.Text = "Raiz Quadrada";
            this.rbRaiz.UseVisualStyleBackColor = true;
            this.rbRaiz.CheckedChanged += new System.EventHandler(this.RbRaiz_CheckedChanged);
            // 
            // FrmCalcRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 348);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.lblIgual);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCalcRadio";
            this.Text = "FrmCalcRadio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Dividir;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton Subtrair;
        private System.Windows.Forms.RadioButton Somar;
        private System.Windows.Forms.RadioButton Potenciacao;
        private System.Windows.Forms.TextBox N1;
        private System.Windows.Forms.TextBox N2;
        private System.Windows.Forms.Label lblIgual;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rbRaiz;
    }
}