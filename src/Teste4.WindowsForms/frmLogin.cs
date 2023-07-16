using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste4.WindowsForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                FrmNotas frmNotas = new FrmNotas();
                frmNotas.Show();
                this.Hide();
            }
        }

        private bool validarCampos()
        {
            bool isValid = true;
            errorProvider.Clear();
            if (txtLogin.Text == string.Empty)
            {
                errorProvider.SetError(txtLogin, "O Login é obrigatório");
                isValid = false;
            }
            if (txtSenha.Text == string.Empty)
            {
                errorProvider.SetError(txtSenha, "A Senha é obrigatório");
                isValid = false;
            }
            return isValid;
        }
    }
}
