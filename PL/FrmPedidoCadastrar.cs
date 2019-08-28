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
    public partial class FrmPedidoCadastrar : Form
    {
        public Cliente cliente = new Cliente();
        public Produto produto = new Produto();
        public Pedido pedido = new Pedido();
        public Item_Venda item = new Item_Venda();

        private string idSelecionado;
        private string CodSelecionado;
        public FrmPedidoCadastrar()
        {
            InitializeComponent();
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoSelecionar frmProdutoSelecionar = new FrmProdutoSelecionar(Acao.Inserir);
            

            if (frmProdutoSelecionar.ShowDialog() == DialogResult.OK)
            {
                int codigoProduto = frmProdutoSelecionar.ProdutoSelecionadoPedido;
                this.produto = PizzariaBLL.BuscarProdutoBLL(codigoProduto);
                string[] linhaProduto = { frmProdutoSelecionar.produto.CodProduto.ToString(), frmProdutoSelecionar.produto.DescricaoProduto, frmProdutoSelecionar.produto.Categoria, frmProdutoSelecionar.produto.Preco };
                GridItemVenda.Rows.Add(linhaProduto);
                ValorTotalPedido();
            }
        }

        public void ValorTotalPedido()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in GridItemVenda.Rows)
            {
                total += Convert.ToDecimal(row.Cells["ColumnPreco"].Value);
            }

            txtValorTotal.Text = Convert.ToDecimal(total).ToString();
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            abasPedidos.SelectTab(0);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Grid.Rows.Clear();

            string[] filtros = { txtPesquisar.Text };

            List<Cliente> Clientes = PizzariaBLL.BuscarClienteDAL(filtros);

            foreach (var cliente in Clientes)
            {
                string[] linhaCliente = { cliente.Id.ToString(), cliente.Nome, cliente.CPF, cliente.Telefone, cliente.Celular, cliente.TelAdicional, cliente.Endereco, cliente.Numero, cliente.Bairro, cliente.Complemento, cliente.Cidade, cliente.UF, cliente.CEP };
                Grid.Rows.Add(linhaCliente);
            }
        }

        private void FrmPedidoCadastrar_Load(object sender, EventArgs e)
        {
            abasPedidos.SelectTab(1);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            int CodigoCliente = int.Parse(Grid.CurrentRow.Cells["ColumnID"].Value.ToString());


            if (CodigoCliente != 0)
            {
                cliente = PizzariaBLL.BuscarClienteBLL(CodigoCliente);

                string[] linhaCliente = { cliente.Id.ToString(), cliente.Nome, cliente.CPF, cliente.Telefone, cliente.Celular, cliente.TelAdicional, cliente.Endereco, cliente.Numero, cliente.Bairro, cliente.Complemento, cliente.Cidade, cliente.UF, cliente.CEP };
                txtClientePedido.Text = cliente.Nome;
                txtCodCliente.Text = cliente.Id.ToString();
                abasPedidos.SelectTab(1);
            }


            Grid.Rows.Clear();

            string[] filtros = { txtPesquisar.Text };

            List<Cliente> Clientes = PizzariaBLL.BuscarClienteDAL(filtros);

            foreach (var cliente in Clientes)
            {
                string[] linhaCliente = { cliente.Id.ToString(), cliente.Nome, cliente.CPF, cliente.Telefone, cliente.Celular, cliente.TelAdicional, cliente.Endereco, cliente.Numero, cliente.Bairro, cliente.Complemento, cliente.Cidade, cliente.UF, cliente.CEP };
                Grid.Rows.Add(linhaCliente);
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FrmClienteCadastrar frmClienteCadastrar = new FrmClienteCadastrar();
            frmClienteCadastrar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pedido == null)
                pedido = new Pedido();

            pedido.CodCliente = Convert.ToInt32(txtCodCliente.Text);
            pedido.NomeCliente = txtClientePedido.Text;
            pedido.ValorTotalPedido = float.Parse(txtValorTotal.Text);
            pedido.ObservacaoPedido = txtObsPedido.Text;

            PizzariaBLL.InserirPedidoBLL(pedido);

            item = new Item_Venda();
            item.CodProduto = produto.CodProduto;

            PizzariaBLL.InserirItemBLL(item);

            MessageBox.Show("Código Cliente: " + pedido.CodCliente + "\n" + "Cliente: " + pedido.NomeCliente + "\n" + "Obs: " + pedido.ObservacaoPedido + "\n" + "VALOR TOTAL: " + pedido.ValorTotalPedido);

            GridItemVenda.Rows.Clear();
            pedido = null;

            txtCodCliente.Text = "";
            txtClientePedido.Text = "";
            txtValorTotal.Text = "";
            txtObsPedido.Text = "";
            btnSelecionarCliente.Focus();

        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnIncluir_Click(null, null);
        }
    }
}
