using MySql.Data.MySqlClient;
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
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void FrmNotas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            this.LimparCampos();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            float notaCorte = float.Parse("6,5");
            if (validarCampos())
            {
                string resultado = String.Empty;
                float mediaNotas = this.calcularMedia();
                if (mediaNotas >= notaCorte)
                {
                    resultado = "Aprovado";
                    lblResultado.ForeColor = Color.Green;
                } else
                {
                    resultado = "Reprovado";
                    lblResultado.ForeColor = Color.Red;
                }
                lblResultado.Text = resultado;

                this.save();
            }
        }

        private float calcularMedia()
        {
            float notaPrimeiroSemestre = float.Parse(txtNotaPrimeiroSemestre.Text);
            float notaSegundoSemestre = float.Parse(txtNotaSegundoSemestre.Text);
            return (notaPrimeiroSemestre + notaSegundoSemestre) / 2;
        }

        private void LimparCampos()
        {
            txtNomeDoAluno.Text = string.Empty;
            txtNotaPrimeiroSemestre.Text = string.Empty;
            txtNotaSegundoSemestre.Text = string.Empty;
            lblResultado.Text = "Nota não Enviada";
            lblResultado.ForeColor = Color.Black;
        }

        private bool validarCampos()
        {
            bool isValid = true;
            string erroNomeAluno = "O Nome do aluno é obrigatório";
            string erroNotaPrimeiroSemestre = "A Nota é obrigatória";
            string erroNotaSegundoSemestre = "A Nota é obrigatória";
            lblResultado.Text = "Nota não Enviada";
            lblResultado.ForeColor = Color.Black;
            lblErroNomeDoAluno.Text = String.Empty;
            lblErroNotaPrimeiroSemestre.Text = String.Empty;
            lblErroNotaSegundoSemestre.Text = String.Empty;

            if (txtNomeDoAluno.Text == string.Empty)
            {
                lblErroNomeDoAluno.Text = erroNomeAluno;
                isValid = false;
            }
            if (txtNotaPrimeiroSemestre.Text == string.Empty)
            {
                lblErroNotaPrimeiroSemestre.Text = erroNotaPrimeiroSemestre;
                isValid = false;
            }
            if (txtNotaSegundoSemestre.Text == string.Empty)
            {
                lblErroNotaSegundoSemestre.Text = erroNotaSegundoSemestre;
                isValid = false;
            }
            return isValid;
        }

        private void save()
        {
            string connetionString = null;
            connetionString = "server=localhost;database=escola;uid=root;pwd=root;";
            using (MySqlConnection cn = new MySqlConnection(connetionString))
            {
                try
                {
                    string query = "insert into alunos (nome, notaPrimeiroSemestre, notaSegundoSemestre, ano) values (?nome, ?notaPrimeiroSemestre, ?notaSegundoSemestre, ?ano)";
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = txtNomeDoAluno.Text;
                        cmd.Parameters.Add("?notaPrimeiroSemestre", MySqlDbType.Float).Value = txtNotaPrimeiroSemestre.Text;
                        cmd.Parameters.Add("?notaSegundoSemestre", MySqlDbType.Float).Value = txtNotaSegundoSemestre.Text;
                        cmd.Parameters.Add("?ano", MySqlDbType.Int32).Value = DateTime.Now.Year;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Não foi possível gravar dados do aluno");
                }
            }
        }
    }
}
