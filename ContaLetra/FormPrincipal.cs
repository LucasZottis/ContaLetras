using System;
using System.Windows.Forms;

namespace ContaLetrar {
    public partial class FormPrincipal : Form {

        #region Atributos

        private int iAlturaTextBox;
        private bool bPrimeiraVez = true;

        #endregion

        #region Construtores

        public FormPrincipal()
        {
            InitializeComponent();
            iAlturaTextBox = txtFrase.Size.Height;
        }

        #endregion Construtores

        #region Eventos de formulário

        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Escape)
                Close();
        }

        #endregion

        #region Eventos de TextBox

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            lbQuantidadeLetra.Text = txtFrase.Text.Length.ToString();
        }

        private void txtFrase_SizeChanged(object sender, EventArgs e)
        {
            if (!bPrimeiraVez)
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

            lblTamanhoCampo.Text = txtFrase.Width.ToString();

            bPrimeiraVez = false;
        }

        private void txtFrase_KeyDown( object sender, KeyEventArgs e )
        {
            switch ( e.KeyData )
            {
                case Keys.Escape:
                {
                    Close();
                    break;
                }
            }
        }

        #endregion Eventos de TextBox

        #region Eventos de Button

        private void btnFonte_Click(object sender, EventArgs e)
        {
            if (fdEscolhaFonte.ShowDialog() == DialogResult.OK)
                txtFrase.Font = fdEscolhaFonte.Font;
        }

        #endregion
    }
}
