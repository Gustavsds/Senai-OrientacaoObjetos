namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmComissao2
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
            this.lblNomeColaborador2 = new System.Windows.Forms.Label();
            this.lblCodigoProduto2 = new System.Windows.Forms.Label();
            this.lblValorProduto2 = new System.Windows.Forms.Label();
            this.lblQuantidadeVendida2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnviar2 = new System.Windows.Forms.Button();
            this.ltbInformaçoes2 = new System.Windows.Forms.ListBox();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.cmbCodigoProduto2 = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeVendida2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNomeColaborador2
            // 
            this.lblNomeColaborador2.AutoSize = true;
            this.lblNomeColaborador2.Location = new System.Drawing.Point(21, 39);
            this.lblNomeColaborador2.Name = "lblNomeColaborador2";
            this.lblNomeColaborador2.Size = new System.Drawing.Size(126, 15);
            this.lblNomeColaborador2.TabIndex = 0;
            this.lblNomeColaborador2.Text = "Nome do Colaborador";
            // 
            // lblCodigoProduto2
            // 
            this.lblCodigoProduto2.AutoSize = true;
            this.lblCodigoProduto2.Location = new System.Drawing.Point(222, 39);
            this.lblCodigoProduto2.Name = "lblCodigoProduto2";
            this.lblCodigoProduto2.Size = new System.Drawing.Size(109, 15);
            this.lblCodigoProduto2.TabIndex = 1;
            this.lblCodigoProduto2.Text = "Codigo do Produto";
            // 
            // lblValorProduto2
            // 
            this.lblValorProduto2.AutoSize = true;
            this.lblValorProduto2.Location = new System.Drawing.Point(76, 120);
            this.lblValorProduto2.Name = "lblValorProduto2";
            this.lblValorProduto2.Size = new System.Drawing.Size(38, 15);
            this.lblValorProduto2.TabIndex = 2;
            this.lblValorProduto2.Text = "label3";
            // 
            // lblQuantidadeVendida2
            // 
            this.lblQuantidadeVendida2.AutoSize = true;
            this.lblQuantidadeVendida2.Location = new System.Drawing.Point(255, 121);
            this.lblQuantidadeVendida2.Name = "lblQuantidadeVendida2";
            this.lblQuantidadeVendida2.Size = new System.Drawing.Size(38, 15);
            this.lblQuantidadeVendida2.TabIndex = 3;
            this.lblQuantidadeVendida2.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 23);
            this.textBox1.TabIndex = 4;
            // 
            // btnEnviar2
            // 
            this.btnEnviar2.Location = new System.Drawing.Point(140, 301);
            this.btnEnviar2.Name = "btnEnviar2";
            this.btnEnviar2.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar2.TabIndex = 7;
            this.btnEnviar2.Text = "ENVIAR";
            this.btnEnviar2.UseVisualStyleBackColor = true;
            // 
            // ltbInformaçoes2
            // 
            this.ltbInformaçoes2.FormattingEnabled = true;
            this.ltbInformaçoes2.ItemHeight = 15;
            this.ltbInformaçoes2.Location = new System.Drawing.Point(21, 186);
            this.ltbInformaçoes2.Name = "ltbInformaçoes2";
            this.ltbInformaçoes2.Size = new System.Drawing.Size(316, 109);
            this.ltbInformaçoes2.TabIndex = 8;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(79, 157);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(38, 15);
            this.lblValor2.TabIndex = 9;
            this.lblValor2.Text = "label5";
            // 
            // cmbCodigoProduto2
            // 
            this.cmbCodigoProduto2.FormattingEnabled = true;
            this.cmbCodigoProduto2.Location = new System.Drawing.Point(216, 57);
            this.cmbCodigoProduto2.Name = "cmbCodigoProduto2";
            this.cmbCodigoProduto2.Size = new System.Drawing.Size(121, 23);
            this.cmbCodigoProduto2.TabIndex = 10;
            // 
            // txtQuantidadeVendida2
            // 
            this.txtQuantidadeVendida2.Location = new System.Drawing.Point(216, 157);
            this.txtQuantidadeVendida2.Name = "txtQuantidadeVendida2";
            this.txtQuantidadeVendida2.Size = new System.Drawing.Size(121, 23);
            this.txtQuantidadeVendida2.TabIndex = 11;
            // 
            // frmComissao2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 336);
            this.Controls.Add(this.txtQuantidadeVendida2);
            this.Controls.Add(this.cmbCodigoProduto2);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.ltbInformaçoes2);
            this.Controls.Add(this.btnEnviar2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQuantidadeVendida2);
            this.Controls.Add(this.lblValorProduto2);
            this.Controls.Add(this.lblCodigoProduto2);
            this.Controls.Add(this.lblNomeColaborador2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComissao2";
            this.Text = "frmComissao2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeColaborador2;
        private Label lblCodigoProduto2;
        private Label lblValorProduto2;
        private Label lblQuantidadeVendida2;
        private TextBox textBox1;
        private Button btnEnviar2;
        private ListBox ltbInformaçoes2;
        private Label lblValor2;
        private ComboBox cmbCodigoProduto2;
        private TextBox txtQuantidadeVendida2;
    }
}