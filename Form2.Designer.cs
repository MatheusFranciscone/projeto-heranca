namespace herança
{
    partial class frm_Menu
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
            this.btn_Aluno = new System.Windows.Forms.Button();
            this.btn_Professor = new System.Windows.Forms.Button();
            this.lbl_BemVindo = new System.Windows.Forms.Label();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aluno
            // 
            this.btn_Aluno.BackColor = System.Drawing.Color.White;
            this.btn_Aluno.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aluno.ForeColor = System.Drawing.Color.Green;
            this.btn_Aluno.Location = new System.Drawing.Point(57, 138);
            this.btn_Aluno.Name = "btn_Aluno";
            this.btn_Aluno.Size = new System.Drawing.Size(96, 41);
            this.btn_Aluno.TabIndex = 0;
            this.btn_Aluno.Text = "Aluno";
            this.btn_Aluno.UseVisualStyleBackColor = false;
            this.btn_Aluno.Click += new System.EventHandler(this.btn_Aluno_Click);
            // 
            // btn_Professor
            // 
            this.btn_Professor.BackColor = System.Drawing.Color.White;
            this.btn_Professor.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Professor.ForeColor = System.Drawing.Color.Green;
            this.btn_Professor.Location = new System.Drawing.Point(243, 138);
            this.btn_Professor.Name = "btn_Professor";
            this.btn_Professor.Size = new System.Drawing.Size(96, 41);
            this.btn_Professor.TabIndex = 1;
            this.btn_Professor.Text = "Professor";
            this.btn_Professor.UseVisualStyleBackColor = false;
            this.btn_Professor.Click += new System.EventHandler(this.btn_Professor_Click);
            // 
            // lbl_BemVindo
            // 
            this.lbl_BemVindo.AutoSize = true;
            this.lbl_BemVindo.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BemVindo.ForeColor = System.Drawing.Color.White;
            this.lbl_BemVindo.Location = new System.Drawing.Point(119, 28);
            this.lbl_BemVindo.Name = "lbl_BemVindo";
            this.lbl_BemVindo.Size = new System.Drawing.Size(156, 31);
            this.lbl_BemVindo.TabIndex = 2;
            this.lbl_BemVindo.Text = "Bem-vindo!";
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.ForeColor = System.Drawing.Color.White;
            this.lbl_Texto.Location = new System.Drawing.Point(27, 59);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(339, 17);
            this.lbl_Texto.TabIndex = 3;
            this.lbl_Texto.Text = "Clique no botão corrresponde a sua ocupação!";
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(391, 238);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.lbl_BemVindo);
            this.Controls.Add(this.btn_Professor);
            this.Controls.Add(this.btn_Aluno);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aluno;
        private System.Windows.Forms.Button btn_Professor;
        private System.Windows.Forms.Label lbl_BemVindo;
        private System.Windows.Forms.Label lbl_Texto;
    }
}