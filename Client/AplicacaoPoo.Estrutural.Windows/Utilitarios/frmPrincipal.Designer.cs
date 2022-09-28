namespace AplicacaoPoo.Estrutural.Windows.Utilitarios
{
    partial class frmPrincipal
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
            this.btnComissao = new System.Windows.Forms.Button();
            this.btnConversor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComissao
            // 
            this.btnComissao.Location = new System.Drawing.Point(12, 47);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(149, 93);
            this.btnComissao.TabIndex = 0;
            this.btnComissao.Text = "COMISSÃO";
            this.btnComissao.UseVisualStyleBackColor = true;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // btnConversor
            // 
            this.btnConversor.Location = new System.Drawing.Point(194, 47);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(154, 93);
            this.btnConversor.TabIndex = 1;
            this.btnConversor.Text = "CONVERSOR";
            this.btnConversor.UseVisualStyleBackColor = true;
            this.btnConversor.Click += new System.EventHandler(this.btnConversor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 194);
            this.Controls.Add(this.btnConversor);
            this.Controls.Add(this.btnComissao);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnComissao;
        private Button btnConversor;
    }
}