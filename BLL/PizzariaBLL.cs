using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PizzariaBLL
    {
        public static int InserirClienteBLL(Cliente cliente)
        {
            return PizzariaDAL.InserirClienteDAL(cliente);
        }
        public static List<Cliente> BuscarClienteDAL(string[] filtros)
        {
            return PizzariaDAL.BuscarClienteDAL(filtros);
        }
        public static Cliente BuscarClienteBLL(int CodigoCliente)
        {
            return PizzariaDAL.BuscarClienteDAL(CodigoCliente);
        }
        public static void AtualizarClienteBLL(Cliente cliente)
        {
            PizzariaDAL.AtualizarClienteDAL(cliente);
        }
        public static void ExcluirClienteBLL(int CodigoCliente)
        {
            PizzariaDAL.ExcluirClienteDAL(CodigoCliente);
        }

        public static int InserirProdutoBLL(Produto produto)
        {
            return PizzariaDAL.InserirProdutoDAL(produto);
        }
        public static List<Produto> BuscarProdutoDAL(string[] filtros)
        {
            return PizzariaDAL.BuscarProdutoDAL(filtros);
        }
        public static Produto BuscarProdutoBLL(int CodigoProduto)
        {
            return PizzariaDAL.BuscarProdutoDAL(CodigoProduto);
        }
        public static void AtualizarProdutoBLL(Produto produto)
        {
            PizzariaDAL.AtualizarProdutoDAL(produto);
        }
        public static void ExcluirProdutoBLL(int CodigoProduto)
        {
            PizzariaDAL.ExcluirProdutoDAL(CodigoProduto);
        }

        public static int InserirPedidoBLL(Pedido pedido)
        {
            return PizzariaDAL.InserirPedidoDAL(pedido);
        }
        public static int InserirItemBLL(Item_Venda item)
        {
            return PizzariaDAL.InserirItemDAL(item);
        }
    }
}
