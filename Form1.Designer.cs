namespace herança
{
    partial class frm_CadastroAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.txt_Curso = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Green;
            this.btn_Cadastrar.Location = new System.Drawing.Point(20, 204);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(271, 46);
            this.btn_Cadastrar.TabIndex = 4;
            this.btn_Cadastrar.Text = "Cadastrar Aluno";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.ForeColor = System.Drawing.Color.White;
            this.lbl_Idade.Location = new System.Drawing.Point(24, 91);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(46, 16);
            this.lbl_Idade.TabIndex = 1;
            this.lbl_Idade.Text = "Idade:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.lbl_Nome.Location = new System.Drawing.Point(24, 50);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(46, 16);
            this.lbl_Nome.TabIndex = 2;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.ForeColor = System.Drawing.Color.White;
            this.lbl_Matricula.Location = new System.Drawing.Point(24, 129);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(66, 16);
            this.lbl_Matricula.TabIndex = 3;
            this.lbl_Matricula.Text = "Matricula:";
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.ForeColor = System.Drawing.Color.White;
            this.lbl_Curso.Location = new System.Drawing.Point(24, 169);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(47, 16);
            this.lbl_Curso.TabIndex = 4;
            this.lbl_Curso.Text = "Curso:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.ForeColor = System.Drawing.Color.Green;
            this.txt_Nome.Location = new System.Drawing.Point(97, 47);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(232, 23);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // txt_Idade
            // 
            this.txt_Idade.ForeColor = System.Drawing.Color.Green;
            this.txt_Idade.Location = new System.Drawing.Point(97, 88);
            this.txt_Idade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Idade.MaxLength = 2;
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(47, 23);
            this.txt_Idade.TabIndex = 1;
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.ForeColor = System.Drawing.Color.Green;
            this.txt_Matricula.Location = new System.Drawing.Point(97, 126);
            this.txt_Matricula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(116, 23);
            this.txt_Matricula.TabIndex = 2;
            this.txt_Matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Matricula_KeyPress);
            // 
            // txt_Curso
            // 
            this.txt_Curso.ForeColor = System.Drawing.Color.Green;
            this.txt_Curso.Location = new System.Drawing.Point(97, 166);
            this.txt_Curso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Size = new System.Drawing.Size(232, 23);
            this.txt_Curso.TabIndex = 3;
            this.txt_Curso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Curso_KeyPress);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.ForeColor = System.Drawing.Color.Green;
            this.btn_Sair.Location = new System.Drawing.Point(317, 204);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 46);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Fechar";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(85, 9);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(236, 23);
            this.lbl_Texto.TabIndex = 19;
            this.lbl_Texto.Text = "Digite sua informações!";
            // 
            // frm_CadastroAluno
            // 
            this.AcceptButton = this.btn_Cadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(414, 265);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.txt_Curso);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Curso);
            this.Controls.Add(this.lbl_Matricula);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.btn_Cadastrar);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_CadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.TextBox txt_Curso;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_Texto;
    }
}

