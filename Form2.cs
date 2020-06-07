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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_Aluno_Click(object sender, EventArgs e)
        {
            frm_CadastroAluno cadAluno = new frm_CadastroAluno();
            cadAluno.Show();
            this.Hide();
        }

        private void btn_Professor_Click(object sender, EventArgs e)
        {
            frm_CadastroProf cadProf = new frm_CadastroProf();
            cadProf.Show();
            this.Hide();
        }
    }
}
