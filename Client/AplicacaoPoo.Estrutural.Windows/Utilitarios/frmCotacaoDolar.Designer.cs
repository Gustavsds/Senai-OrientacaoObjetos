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
            this.lblQuantiaDolar = new System.Windows.Forms.Label();
            this.txtQuantia = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.cmbMoedaDesejada = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblQuantiaDolar
            // 
            this.lblQuantiaDolar.AutoSize = true;
            this.lblQuantiaDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantiaDolar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantiaDolar.ForeColor = System.Drawing.Color.White;
            this.lblQuantiaDolar.Location = new System.Drawing.Point(16, 90);
            this.lblQuantiaDolar.Name = "lblQuantiaDolar";
            this.lblQuantiaDolar.Size = new System.Drawing.Size(138, 25);
            this.lblQuantiaDolar.TabIndex = 1;
            this.lblQuantiaDolar.Text = "Valor desejado :";
            // 
            // txtQuantia
            // 
            this.txtQuantia.BackColor = System.Drawing.Color.Silver;
            this.txtQuantia.ForeColor = System.Drawing.Color.White;
            this.txtQuantia.Location = new System.Drawing.Point(240, 91);
            this.txtQuantia.Name = "txtQuantia";
            this.txtQuantia.Size = new System.Drawing.Size(81, 23);
            this.txtQuantia.TabIndex = 5;
            this.txtQuantia.TextChanged += new System.EventHandler(this.txtQuantiaDolar_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox2.Location = new System.Drawing.Point(14, 88);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(310, 30);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.BackColor = System.Drawing.Color.Black;
            this.lblPrimeiroValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(33, 9);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(191, 19);
            this.lblPrimeiroValor.TabIndex = 7;
            this.lblPrimeiroValor.Text = "1 Dolares americanos igual a :";
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(33, 28);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(159, 60);
            this.lblSegundoValor.TabIndex = 8;
            this.lblSegundoValor.Text = "5,12 \r\nReal Brasileiro";
            // 
            // cmbMoedaDesejada
            // 
            this.cmbMoedaDesejada.FormattingEnabled = true;
            this.cmbMoedaDesejada.Items.AddRange(new object[] {
            "Dólar Americano",
            "Euro",
            "Libra Esterlinas"});
            this.cmbMoedaDesejada.Location = new System.Drawing.Point(240, 64);
            this.cmbMoedaDesejada.Name = "cmbMoedaDesejada";
            this.cmbMoedaDesejada.Size = new System.Drawing.Size(84, 23);
            this.cmbMoedaDesejada.TabIndex = 9;
            this.cmbMoedaDesejada.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(338, 176);
            this.Controls.Add(this.cmbMoedaDesejada);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.txtQuantia);
            this.Controls.Add(this.lblQuantiaDolar);
            this.Controls.Add(this.richTextBox2);
            this.Name = "frmCotacaoDolar";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Label lblQuantiaDolar;
        private TextBox txtQuantia;
        private RichTextBox richTextBox2;
        private Label lblPrimeiroValor;
        private Label lblSegundoValor;
        private ComboBox cmbMoedaDesejada;
    }
}