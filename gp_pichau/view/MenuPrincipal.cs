using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp_pichau.view
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar telacadastrar= new Cadastrar();
            telacadastrar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarPecas pesquisarpecas = new PesquisarPecas();
            pesquisarpecas.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarPeca alterarpecas= new AlterarPeca();
            alterarpecas.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletarPeca deletarpecas = new deletarPeca();
            deletarpecas.Show();
        }
    }
}
