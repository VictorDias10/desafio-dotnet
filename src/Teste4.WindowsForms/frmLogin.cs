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
            string erroLogin = "O Login é obrigatório";
            string erroSenha = "A Senha é obrigatório";
            List<string> erros = new List<string>();

            errorProvider.Clear();
            lblErro.Text = String.Empty;
            if (txtLogin.Text == string.Empty)
            {
                errorProvider.SetError(txtLogin, erroLogin);
                erros.Add(erroLogin);
                isValid = false;
            }
            if (txtSenha.Text == string.Empty)
            {
                errorProvider.SetError(txtSenha, erroSenha);
                erros.Add(erroSenha);
                isValid = false;
            }
            foreach(string erro in erros)
            {
                lblErro.Text += $"\n{erro}"; 
            }

            return isValid;
        }
    }
}
