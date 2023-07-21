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
    public partial class deletarPeca : Form
    {
        public deletarPeca()
        {
            InitializeComponent();
        }

                private void BUSCAR_Click(object sender, EventArgs e)
        {
            classPecas.Codigo = Convert.ToInt32(textBox1.Text);
            manipulaPecas mpecas = new manipulaPecas();
            mpecas.buscPecas();

            textBox2.Text = classPecas.Codigo.ToString();
            textBox3.Text = classPecas.Peca;
            textBox4.Text = classPecas.Marca;
            textBox5.Text = classPecas.Capacidade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classPecas.Codigo = Convert.ToInt32(textBox2.Text);
            manipulaPecas mpecas = new manipulaPecas();
            mpecas.deletPeca();

            textBox2.Text = classPecas.Codigo.ToString();
            textBox3.Text = classPecas.Peca;
            textBox4.Text = classPecas.Marca;
            textBox5.Text = classPecas.Capacidade;
        }
    }
}
