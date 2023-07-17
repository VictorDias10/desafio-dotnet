namespace Teste4.WindowsForms
{
    partial class FrmNotas
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblErroNomeDoAluno = new System.Windows.Forms.Label();
            this.lblNotaSegundoSemestre = new System.Windows.Forms.Label();
            this.txtNotaSegundoSemestre = new System.Windows.Forms.TextBox();
            this.lblNotaPrimeiroSemestre = new System.Windows.Forms.Label();
            this.txtNotaPrimeiroSemestre = new System.Windows.Forms.TextBox();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblNomeDoAluno = new System.Windows.Forms.Label();
            this.txtNomeDoAluno = new System.Windows.Forms.TextBox();
            this.lblStatusAluno = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblErroNotaPrimeiroSemestre = new System.Windows.Forms.Label();
            this.lblErroNotaSegundoSemestre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(67, 228);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(171, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblErroNomeDoAluno
            // 
            this.lblErroNomeDoAluno.AutoSize = true;
            this.lblErroNomeDoAluno.ForeColor = System.Drawing.Color.Red;
            this.lblErroNomeDoAluno.Location = new System.Drawing.Point(64, 117);
            this.lblErroNomeDoAluno.Name = "lblErroNomeDoAluno";
            this.lblErroNomeDoAluno.Size = new System.Drawing.Size(0, 16);
            this.lblErroNomeDoAluno.TabIndex = 10;
            // 
            // lblNotaSegundoSemestre
            // 
            this.lblNotaSegundoSemestre.AutoSize = true;
            this.lblNotaSegundoSemestre.Location = new System.Drawing.Point(242, 150);
            this.lblNotaSegundoSemestre.Name = "lblNotaSegundoSemestre";
            this.lblNotaSegundoSemestre.Size = new System.Drawing.Size(134, 16);
            this.lblNotaSegundoSemestre.TabIndex = 9;
            this.lblNotaSegundoSemestre.Text = "Nota do 2º Semestre:";
            // 
            // txtNotaSegundoSemestre
            // 
            this.txtNotaSegundoSemestre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaSegundoSemestre.Location = new System.Drawing.Point(245, 169);
            this.txtNotaSegundoSemestre.Name = "txtNotaSegundoSemestre";
            this.txtNotaSegundoSemestre.Size = new System.Drawing.Size(131, 22);
            this.txtNotaSegundoSemestre.TabIndex = 8;
            // 
            // lblNotaPrimeiroSemestre
            // 
            this.lblNotaPrimeiroSemestre.AutoSize = true;
            this.lblNotaPrimeiroSemestre.Location = new System.Drawing.Point(64, 150);
            this.lblNotaPrimeiroSemestre.Name = "lblNotaPrimeiroSemestre";
            this.lblNotaPrimeiroSemestre.Size = new System.Drawing.Size(134, 16);
            this.lblNotaPrimeiroSemestre.TabIndex = 7;
            this.lblNotaPrimeiroSemestre.Text = "Nota do 1º Semestre:";
            // 
            // txtNotaPrimeiroSemestre
            // 
            this.txtNotaPrimeiroSemestre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotaPrimeiroSemestre.Location = new System.Drawing.Point(67, 169);
            this.txtNotaPrimeiroSemestre.Name = "txtNotaPrimeiroSemestre";
            this.txtNotaPrimeiroSemestre.Size = new System.Drawing.Size(131, 22);
            this.txtNotaPrimeiroSemestre.TabIndex = 6;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(245, 228);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(131, 23);
            this.btnLimparCampos.TabIndex = 11;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // lblNomeDoAluno
            // 
            this.lblNomeDoAluno.AutoSize = true;
            this.lblNomeDoAluno.Location = new System.Drawing.Point(64, 68);
            this.lblNomeDoAluno.Name = "lblNomeDoAluno";
            this.lblNomeDoAluno.Size = new System.Drawing.Size(103, 16);
            this.lblNomeDoAluno.TabIndex = 13;
            this.lblNomeDoAluno.Text = "Nome do Aluno:";
            // 
            // txtNomeDoAluno
            // 
            this.txtNomeDoAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeDoAluno.Location = new System.Drawing.Point(67, 87);
            this.txtNomeDoAluno.Name = "txtNomeDoAluno";
            this.txtNomeDoAluno.Size = new System.Drawing.Size(309, 22);
            this.txtNomeDoAluno.TabIndex = 12;
            // 
            // lblStatusAluno
            // 
            this.lblStatusAluno.AutoSize = true;
            this.lblStatusAluno.Location = new System.Drawing.Point(64, 388);
            this.lblStatusAluno.Name = "lblStatusAluno";
            this.lblStatusAluno.Size = new System.Drawing.Size(103, 16);
            this.lblStatusAluno.TabIndex = 14;
            this.lblStatusAluno.Text = "Status do Aluno:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(184, 388);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 16);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "Nota não Enviada";
            // 
            // lblErroNotaPrimeiroSemestre
            // 
            this.lblErroNotaPrimeiroSemestre.AutoSize = true;
            this.lblErroNotaPrimeiroSemestre.ForeColor = System.Drawing.Color.Red;
            this.lblErroNotaPrimeiroSemestre.Location = new System.Drawing.Point(64, 202);
            this.lblErroNotaPrimeiroSemestre.Name = "lblErroNotaPrimeiroSemestre";
            this.lblErroNotaPrimeiroSemestre.Size = new System.Drawing.Size(0, 16);
            this.lblErroNotaPrimeiroSemestre.TabIndex = 16;
            // 
            // lblErroNotaSegundoSemestre
            // 
            this.lblErroNotaSegundoSemestre.AutoSize = true;
            this.lblErroNotaSegundoSemestre.ForeColor = System.Drawing.Color.Red;
            this.lblErroNotaSegundoSemestre.Location = new System.Drawing.Point(242, 202);
            this.lblErroNotaSegundoSemestre.Name = "lblErroNotaSegundoSemestre";
            this.lblErroNotaSegundoSemestre.Size = new System.Drawing.Size(0, 16);
            this.lblErroNotaSegundoSemestre.TabIndex = 17;
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 475);
            this.Controls.Add(this.lblErroNotaSegundoSemestre);
            this.Controls.Add(this.lblErroNotaPrimeiroSemestre);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblStatusAluno);
            this.Controls.Add(this.lblNomeDoAluno);
            this.Controls.Add(this.txtNomeDoAluno);
            this.Controls.Add(this.btnLimparCampos);
            this.Controls.Add(this.lblErroNomeDoAluno);
            this.Controls.Add(this.lblNotaSegundoSemestre);
            this.Controls.Add(this.txtNotaSegundoSemestre);
            this.Controls.Add(this.lblNotaPrimeiroSemestre);
            this.Controls.Add(this.txtNotaPrimeiroSemestre);
            this.Controls.Add(this.btnEnviar);
            this.Name = "FrmNotas";
            this.Text = "lançamento de Notas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNotas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblErroNomeDoAluno;
        private System.Windows.Forms.Label lblNotaSegundoSemestre;
        private System.Windows.Forms.TextBox txtNotaSegundoSemestre;
        private System.Windows.Forms.Label lblNotaPrimeiroSemestre;
        private System.Windows.Forms.TextBox txtNotaPrimeiroSemestre;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblNomeDoAluno;
        private System.Windows.Forms.TextBox txtNomeDoAluno;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblStatusAluno;
        private System.Windows.Forms.Label lblErroNotaPrimeiroSemestre;
        private System.Windows.Forms.Label lblErroNotaSegundoSemestre;
    }
}