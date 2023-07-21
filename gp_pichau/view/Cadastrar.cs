using gp_pichau.controller;
using gp_pichau.model;
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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btncadastrarpecas_Click(object sender, EventArgs e)
        {
            classPecas.Peca = txtboxPeca.Text;
            classPecas.Marca = txtboxmarca.Text;
            classPecas.Capacidade = txtboxcapacidade.Text;

            manipulaPecas mPecas = new manipulaPecas();
            mPecas.cadPecas();
        }
        public void abrirCadastro()
        {
            this.ShowDialog();
        }
    }
}
