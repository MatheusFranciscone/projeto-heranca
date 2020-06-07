using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herança
{
    class Aluno: Pessoa //classe que herda os atributos da classe pessoa
    {
        public int n_matricula;
        public string curso;

        public void exibiraluno()
        {
            System.Windows.Forms.MessageBox.Show( "Nome: " + nome + "\nIdade: " + idade.ToString() + "\nMatrícula: " + n_matricula.ToString() + "\nCurso: " + curso, "Cadastro realizado com sucesso!");
        }

    }
}
