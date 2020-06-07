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
    public partial class frm_CadastroProf : Form
    {
        public frm_CadastroProf()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == ""|| txt_Idade.Text == "" || txt_Disciplina.Text == ""|| txt_Salario.Text == "")
            {
                MessageBox.Show("Digite todos os seu dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                Professor objProf = new Professor();

                objProf.nome = txt_Nome.Text;
                objProf.idade = Convert.ToInt32(txt_Idade.Text);
                objProf.salario = Convert.ToInt32(txt_Salario.Text);
                objProf.disciplina = txt_Disciplina.Text;

                objProf.exibirprof();
                txt_Disciplina.Clear();
                txt_Idade.Clear();
                txt_Nome.Clear();
                txt_Salario.Clear();

                btn_Sair.Focus();
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
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

        private void txt_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txt_Disciplina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
