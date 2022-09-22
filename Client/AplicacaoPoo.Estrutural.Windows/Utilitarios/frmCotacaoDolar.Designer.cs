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
            this.txtQuantiaDolar = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblQuantiaDolar
            // 
            this.lblQuantiaDolar.AutoSize = true;
            this.lblQuantiaDolar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantiaDolar.Location = new System.Drawing.Point(15, 9);
            this.lblQuantiaDolar.Name = "lblQuantiaDolar";
            this.lblQuantiaDolar.Size = new System.Drawing.Size(138, 25);
            this.lblQuantiaDolar.TabIndex = 1;
            this.lblQuantiaDolar.Text = "Valor desejado :";
            // 
            // txtQuantiaDolar
            // 
            this.txtQuantiaDolar.Location = new System.Drawing.Point(239, 9);
            this.txtQuantiaDolar.Name = "txtQuantiaDolar";
            this.txtQuantiaDolar.Size = new System.Drawing.Size(81, 23);
            this.txtQuantiaDolar.TabIndex = 5;
            this.txtQuantiaDolar.TextChanged += new System.EventHandler(this.txtQuantiaDolar_TextChanged);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(129, 52);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(79, 23);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "CONVERTER";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.Location = new System.Drawing.Point(13, 6);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(310, 30);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 123);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtQuantiaDolar);
            this.Controls.Add(this.lblQuantiaDolar);
            this.Controls.Add(this.richTextBox2);
            this.Name = "frmCotacaoDolar";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private Label lblQuantiaDolar;
        private TextBox txtQuantiaDolar;
        private Button btnConverter;
        private RichTextBox richTextBox2;
    }
}