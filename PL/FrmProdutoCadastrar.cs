using BLL;
using DTO;
using System;
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
    public partial class FrmProdutoCadastrar : Form
    {
        public Produto produto = new Produto();

        public FrmProdutoCadastrar(Acao acao)
        {
            InitializeComponent();

            if (acao == Acao.Inserir)
            {
                this.Text = "Cadastrar Produto";
            }

            else if (acao == Acao.Alterar)
            {
                this.Text = "Alterar Produto";
            }
        }

        public FrmProdutoCadastrar(int CodigoProduto)
        {
            InitializeComponent();

            if (CodigoProduto != 0)
            {
                this.Text = "Alterar Produto";
                produto = PizzariaBLL.BuscarProdutoBLL(CodigoProduto);

                txtNome.Text = produto.DescricaoProduto;
                txtPreco.Text = produto.Preco;
                cboCategoria.Text = produto.Categoria;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (produto == null)
                produto = new Produto();

            produto.DescricaoProduto = txtNome.Text;
            produto.Preco = txtPreco.Text;
            produto.Categoria = cboCategoria.Text;

            if (produto.CodProduto == 0)
                produto.CodProduto = PizzariaBLL.InserirProdutoBLL(produto);
            else
                PizzariaBLL.AtualizarProdutoBLL(produto);

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
