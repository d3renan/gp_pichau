using gp_pichau.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gp_pichau.controller;
using gp_pichau.model;

namespace gp_pichau.view
{
    public partial class PesquisarPecas : Form
    {
        public PesquisarPecas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pesquisarCod_Click(object sender, EventArgs e)
        {
            classPecas.Codigo = Convert.ToInt32(buscarCod.Text);

            manipulaPecas mpecas = new manipulaPecas();
            mpecas.buscPecas();

            buscarCod.Text = classPecas.Codigo.ToString();
            buscarCodPeca.Text = classPecas.Peca;
            BuscarCodMarca.Text = classPecas.Marca;
            BuscarCodCapacidade.Text = classPecas.Capacidade;
        }
    }
}
