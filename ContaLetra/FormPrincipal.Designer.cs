
namespace ContadorCaracteres {
    partial class FormPrincipal {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.fdEscolhaFonte = new System.Windows.Forms.FontDialog();
            this.btnFonte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbQuantidadeLetra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTamanhoCampo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase";
            // 
            // txtFrase
            // 
            this.txtFrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrase.Location = new System.Drawing.Point(13, 33);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(445, 22);
            this.txtFrase.TabIndex = 1;
            this.txtFrase.SizeChanged += new System.EventHandler(this.txtFrase_SizeChanged);
            this.txtFrase.TextChanged += new System.EventHandler(this.txtFrase_TextChanged);
            // 
            // fdEscolhaFonte
            // 
            this.fdEscolhaFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fdEscolhaFonte.FontMustExist = true;
            // 
            // btnFonte
            // 
            this.btnFonte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFonte.Location = new System.Drawing.Point(13, 62);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(232, 32);
            this.btnFonte.TabIndex = 2;
            this.btnFonte.Text = "Alterar fonte";
            this.btnFonte.UseVisualStyleBackColor = true;
            this.btnFonte.Click += new System.EventHandler(this.btnFonte_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade de letras:";
            // 
            // lbQuantidadeLetra
            // 
            this.lbQuantidadeLetra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQuantidadeLetra.Location = new System.Drawing.Point(389, 63);
            this.lbQuantidadeLetra.Name = "lbQuantidadeLetra";
            this.lbQuantidadeLetra.Size = new System.Drawing.Size(69, 16);
            this.lbQuantidadeLetra.TabIndex = 4;
            this.lbQuantidadeLetra.Text = "0";
            this.lbQuantidadeLetra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tamanho campo:";
            // 
            // lblTamanhoCampo
            // 
            this.lblTamanhoCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTamanhoCampo.Location = new System.Drawing.Point(389, 82);
            this.lblTamanhoCampo.Name = "lblTamanhoCampo";
            this.lblTamanhoCampo.Size = new System.Drawing.Size(69, 16);
            this.lblTamanhoCampo.TabIndex = 6;
            this.lblTamanhoCampo.Text = "0";
            this.lblTamanhoCampo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(470, 108);
            this.Controls.Add(this.lblTamanhoCampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbQuantidadeLetra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFonte);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(486, 147);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Letra";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.FontDialog fdEscolhaFonte;
        private System.Windows.Forms.Button btnFonte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbQuantidadeLetra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTamanhoCampo;
    }
}