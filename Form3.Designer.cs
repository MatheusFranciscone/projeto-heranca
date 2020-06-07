namespace herança
{
    partial class frm_CadastroProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroProf));
            this.txt_Disciplina = new System.Windows.Forms.TextBox();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Disciplina = new System.Windows.Forms.Label();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Disciplina
            // 
            this.txt_Disciplina.ForeColor = System.Drawing.Color.Green;
            this.txt_Disciplina.Location = new System.Drawing.Point(103, 167);
            this.txt_Disciplina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Disciplina.Name = "txt_Disciplina";
            this.txt_Disciplina.Size = new System.Drawing.Size(243, 23);
            this.txt_Disciplina.TabIndex = 3;
            this.txt_Disciplina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Disciplina_KeyPress);
            // 
            // txt_Salario
            // 
            this.txt_Salario.ForeColor = System.Drawing.Color.Green;
            this.txt_Salario.Location = new System.Drawing.Point(103, 128);
            this.txt_Salario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(116, 23);
            this.txt_Salario.TabIndex = 2;
            this.txt_Salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salario_KeyPress);
            // 
            // txt_Idade
            // 
            this.txt_Idade.ForeColor = System.Drawing.Color.Green;
            this.txt_Idade.Location = new System.Drawing.Point(103, 90);
            this.txt_Idade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Idade.MaxLength = 2;
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(47, 23);
            this.txt_Idade.TabIndex = 1;
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            // 
            // txt_Nome
            // 
            this.txt_Nome.ForeColor = System.Drawing.Color.Green;
            this.txt_Nome.Location = new System.Drawing.Point(103, 49);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(243, 23);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // lbl_Disciplina
            // 
            this.lbl_Disciplina.AutoSize = true;
            this.lbl_Disciplina.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Disciplina.ForeColor = System.Drawing.Color.White;
            this.lbl_Disciplina.Location = new System.Drawing.Point(29, 170);
            this.lbl_Disciplina.Name = "lbl_Disciplina";
            this.lbl_Disciplina.Size = new System.Drawing.Size(68, 16);
            this.lbl_Disciplina.TabIndex = 13;
            this.lbl_Disciplina.Text = "Disciplina:";
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salario.ForeColor = System.Drawing.Color.White;
            this.lbl_Salario.Location = new System.Drawing.Point(31, 131);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(51, 16);
            this.lbl_Salario.TabIndex = 12;
            this.lbl_Salario.Text = "Salário:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.lbl_Nome.Location = new System.Drawing.Point(31, 52);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(46, 16);
            this.lbl_Nome.TabIndex = 11;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idade.ForeColor = System.Drawing.Color.White;
            this.lbl_Idade.Location = new System.Drawing.Point(31, 93);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(46, 16);
            this.lbl_Idade.TabIndex = 10;
            this.lbl_Idade.Text = "Idade:";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.White;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.ForeColor = System.Drawing.Color.Green;
            this.btn_Cadastrar.Location = new System.Drawing.Point(23, 206);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(271, 46);
            this.btn_Cadastrar.TabIndex = 4;
            this.btn_Cadastrar.Text = "Cadastrar Professor";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(90, 9);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(236, 23);
            this.lbl_Texto.TabIndex = 18;
            this.lbl_Texto.Text = "Digite sua informações!";
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.ForeColor = System.Drawing.Color.Green;
            this.btn_Sair.Location = new System.Drawing.Point(317, 206);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(75, 46);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Fechar";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_CadastroProf
            // 
            this.AcceptButton = this.btn_Cadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(414, 265);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.txt_Disciplina);
            this.Controls.Add(this.txt_Salario);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Disciplina);
            this.Controls.Add(this.lbl_Salario);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.btn_Cadastrar);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_CadastroProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Disciplina;
        private System.Windows.Forms.TextBox txt_Salario;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Disciplina;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Button btn_Sair;
    }
}