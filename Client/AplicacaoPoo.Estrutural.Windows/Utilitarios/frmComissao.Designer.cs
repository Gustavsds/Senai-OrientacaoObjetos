namespace AplicacaoPoo.Estrutural.Windows.Utilitarios
{
    partial class frmComissao
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
            this.components = new System.ComponentModel.Container();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.lblQuantidadeVendida = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ltbInformacoes = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Location = new System.Drawing.Point(12, 9);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(110, 15);
            this.lblNomeVendedor.TabIndex = 0;
            this.lblNomeVendedor.Text = "Nome do Vendedor";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(156, 9);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(109, 15);
            this.lblCodigoProduto.TabIndex = 1;
            this.lblCodigoProduto.Text = "Codigo do Produto";
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.AutoSize = true;
            this.lblPrecoProduto.Location = new System.Drawing.Point(12, 71);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.Size = new System.Drawing.Size(100, 15);
            this.lblPrecoProduto.TabIndex = 2;
            this.lblPrecoProduto.Text = "Preço do Produto";
            // 
            // lblQuantidadeVendida
            // 
            this.lblQuantidadeVendida.AutoSize = true;
            this.lblQuantidadeVendida.Location = new System.Drawing.Point(156, 71);
            this.lblQuantidadeVendida.Name = "lblQuantidadeVendida";
            this.lblQuantidadeVendida.Size = new System.Drawing.Size(114, 15);
            this.lblQuantidadeVendida.TabIndex = 3;
            this.lblQuantidadeVendida.Text = "Quantidade vendida";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(12, 27);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(100, 23);
            this.txtNomeVendedor.TabIndex = 4;
            this.txtNomeVendedor.TextChanged += new System.EventHandler(this.txtNomeVendedor_TextChanged);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(161, 27);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoProduto.TabIndex = 5;
            this.txtCodigoProduto.TextChanged += new System.EventHandler(this.txtCodigoProduto_TextChanged);
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(12, 100);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(100, 23);
            this.txtPrecoProduto.TabIndex = 6;
            this.txtPrecoProduto.TextChanged += new System.EventHandler(this.txtPrecoProduto_TextChanged);
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(161, 100);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(100, 23);
            this.txtQuantidadeVendida.TabIndex = 7;
            this.txtQuantidadeVendida.TextChanged += new System.EventHandler(this.txtQuantidadeVendida_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(99, 268);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ltbInformacoes
            // 
            this.ltbInformacoes.FormattingEnabled = true;
            this.ltbInformacoes.ItemHeight = 15;
            this.ltbInformacoes.Location = new System.Drawing.Point(12, 140);
            this.ltbInformacoes.Name = "ltbInformacoes";
            this.ltbInformacoes.Size = new System.Drawing.Size(249, 124);
            this.ltbInformacoes.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 303);
            this.Controls.Add(this.ltbInformacoes);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.lblQuantidadeVendida);
            this.Controls.Add(this.lblPrecoProduto);
            this.Controls.Add(this.lblCodigoProduto);
            this.Controls.Add(this.lblNomeVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComissao";
            this.Text = "Comissão";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeVendedor;
        private Label lblCodigoProduto;
        private Label lblPrecoProduto;
        private Label lblQuantidadeVendida;
        private TextBox txtNomeVendedor;
        private TextBox txtCodigoProduto;
        private TextBox txtPrecoProduto;
        private TextBox txtQuantidadeVendida;
        private Button btnEnviar;
        private ListBox ltbInformacoes;
        private ErrorProvider errorProvider1;
    }
}