using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herança
{
    class Professor: Pessoa
    {
        public string disciplina;
        public int salario;

        public void exibirprof()
        {
                System.Windows.Forms.MessageBox.Show("Nome: " + nome + "\nIdade: " + idade.ToString() + "\nSalário: " + salario.ToString() + "\nDisciplina: " + disciplina, "Cadastro realizado com sucesso!");
        }
    }
}
