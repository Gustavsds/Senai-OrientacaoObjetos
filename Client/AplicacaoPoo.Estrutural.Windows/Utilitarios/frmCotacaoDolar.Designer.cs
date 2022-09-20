namespace AplicacaoPoo.Estrutural.Windows.Utilitarios
{
    partial class frmCotacaoDolar
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
            this.lblCotacaoAtual = new System.Windows.Forms.Label();
            this.lblQuantiaDolar = new System.Windows.Forms.Label();
            this.txtCotacaoAtual = new System.Windows.Forms.TextBox();
            this.txtQuantiaDolar = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblValorReal = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblCotacaoAtual
            // 
            this.lblCotacaoAtual.AutoSize = true;
            this.lblCotacaoAtual.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCotacaoAtual.Location = new System.Drawing.Point(15, 20);
            this.lblCotacaoAtual.Name = "lblCotacaoAtual";
            this.lblCotacaoAtual.Size = new System.Drawing.Size(129, 25);
            this.lblCotacaoAtual.TabIndex = 0;
            this.lblCotacaoAtual.Text = "Cotação atual :";
            // 
            // lblQuantiaDolar
            // 
            this.lblQuantiaDolar.AutoSize = true;
            this.lblQuantiaDolar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantiaDolar.Location = new System.Drawing.Point(14, 54);
            this.lblQuantiaDolar.Name = "lblQuantiaDolar";
            this.lblQuantiaDolar.Size = new System.Drawing.Size(221, 25);
            this.lblQuantiaDolar.TabIndex = 1;
            this.lblQuantiaDolar.Text = "Valor desejado (Em Dolar):";
            // 
            // txtCotacaoAtual
            // 
            this.txtCotacaoAtual.Location = new System.Drawing.Point(238, 23);
            this.txtCotacaoAtual.Name = "txtCotacaoAtual";
            this.txtCotacaoAtual.Size = new System.Drawing.Size(81, 23);
            this.txtCotacaoAtual.TabIndex = 4;
            // 
            // txtQuantiaDolar
            // 
            this.txtQuantiaDolar.Location = new System.Drawing.Point(238, 54);
            this.txtQuantiaDolar.Name = "txtQuantiaDolar";
            this.txtQuantiaDolar.Size = new System.Drawing.Size(81, 23);
            this.txtQuantiaDolar.TabIndex = 5;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(15, 93);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(79, 23);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "CONVERTER";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(283, 97);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 15);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "0";
            // 
            // lblValorReal
            // 
            this.lblValorReal.AutoSize = true;
            this.lblValorReal.Location = new System.Drawing.Point(192, 97);
            this.lblValorReal.Name = "lblValorReal";
            this.lblValorReal.Size = new System.Drawing.Size(72, 15);
            this.lblValorReal.TabIndex = 8;
            this.lblValorReal.Text = "Valor em R$:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(100, 93);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.Location = new System.Drawing.Point(12, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(310, 30);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(12, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(310, 30);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 123);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblValorReal);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtQuantiaDolar);
            this.Controls.Add(this.txtCotacaoAtual);
            this.Controls.Add(this.lblQuantiaDolar);
            this.Controls.Add(this.lblCotacaoAtual);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Name = "frmCotacaoDolar";
            this.Text = "CotacaoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCotacaoAtual;
        private Label lblQuantiaDolar;
        private TextBox txtCotacaoAtual;
        private TextBox txtQuantiaDolar;
        private Button btnConverter;
        private Label lblResultado;
        private Label lblValorReal;
        private Button btnLimpar;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
    }
}