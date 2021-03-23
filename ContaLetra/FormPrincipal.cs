using System;
using System.Windows.Forms;

namespace ContadorCaracteres {
    public partial class FormPrincipal : Form {

        private int iAlturaTextBox;
        private bool bPrimeiraVez = true;

        public FormPrincipal()
        {
            InitializeComponent();
            iAlturaTextBox = txtFrase.Size.Height;
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            lbQuantidadeLetra.Text = txtFrase.Text.Length.ToString();
        }

        private void btnFonte_Click(object sender, EventArgs e)
        {
            if (fdEscolhaFonte.ShowDialog() == DialogResult.OK)
            {
                txtFrase.Font = fdEscolhaFonte.Font;
            }
        }

        private void txtFrase_SizeChanged(object sender, EventArgs e)
        {
            if (!bPrimeiraVez)
            {
                if ((txtFrase.Height - iAlturaTextBox) > 0)
                {
                    Height += Math.Abs(iAlturaTextBox - txtFrase.Size.Height);
                    iAlturaTextBox = txtFrase.Size.Height;
                }
                else
                {
                    Height -= Math.Abs(iAlturaTextBox - txtFrase.Size.Height);
                    iAlturaTextBox = txtFrase.Size.Height;
                }
            }

            lblTamanhoCampo.Text = txtFrase.Width.ToString();

            bPrimeiraVez = false;
        }

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
