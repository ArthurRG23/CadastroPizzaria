﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteSelecionar frmClienteSelecionar = new FrmClienteSelecionar(Acao.Pesquisar);
            frmClienteSelecionar.ShowDialog();
        }


        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoSelecionar frmProdutoSelecionar = new FrmProdutoSelecionar(Acao.Pesquisar);
            frmProdutoSelecionar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidoCadastrar frmPedidoCadastrar = new FrmPedidoCadastrar();
            frmPedidoCadastrar.ShowDialog();
        }
    }
}
