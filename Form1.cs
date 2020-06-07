using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herança
{
    public partial class frm_CadastroAluno : Form
    {
        public frm_CadastroAluno()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_Curso.Text == "" || txt_Idade.Text =="" || txt_Matricula.Text == "" || txt_Nome.Text == "")
            {
                MessageBox.Show("Digite todos os seu dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                Aluno objAluno = new Aluno();

                objAluno.nome = txt_Nome.Text;
                objAluno.idade = Convert.ToInt32(txt_Idade.Text);
                objAluno.n_matricula = Convert.ToInt32(txt_Matricula.Text);
                objAluno.curso = txt_Curso.Text;

                objAluno.exibiraluno();
                txt_Curso.Clear();
                txt_Idade.Clear();
                txt_Matricula.Clear();
                txt_Nome.Clear();

                btn_Sair.Focus();
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_Matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_Curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}