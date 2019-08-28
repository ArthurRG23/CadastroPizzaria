using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PizzariaDAL
    {
        public static int InserirClienteDAL(Cliente cliente)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT CLIENTE (NM_CLIENTE, NR_CPF_CLIENTE, NR_TELEFONE, NR_CELULAR, NR_TEL_ADICIONAL, DS_ENDERECO, NR_ENDERECO, DS_BAIRRO, DS_COMPLEMENTO, DS_CIDADE, DS_UF, NR_CEP) VALUES (@Nome, @CPF, @Telefone, @Celular, @TelefoneAdicional, @Endereco, @Numero, @Bairro, @Complemento, @Cidade, @UF, @CEP)";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = cliente.Nome;
            Comando.Parameters.Add("CPF", SqlDbType.VarChar).Value = cliente.CPF;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = cliente.Telefone;
            Comando.Parameters.Add("Celular", SqlDbType.VarChar).Value = cliente.Celular;
            Comando.Parameters.Add("TelefoneAdicional", SqlDbType.VarChar).Value = cliente.TelAdicional;
            Comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = cliente.Endereco;
            Comando.Parameters.Add("Numero", SqlDbType.VarChar).Value = cliente.Numero;
            Comando.Parameters.Add("Bairro", SqlDbType.VarChar).Value = cliente.Bairro;
            Comando.Parameters.Add("Complemento", SqlDbType.VarChar).Value = cliente.Complemento;
            Comando.Parameters.Add("Cidade", SqlDbType.VarChar).Value = cliente.Cidade;
            Comando.Parameters.Add("UF", SqlDbType.VarChar).Value = cliente.UF;
            Comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = cliente.CEP;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(ID_CLIENTE) FROM CLIENTE";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }
        public static List<Cliente> BuscarClienteDAL(string[] filtros)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT ID_CLIENTE, NM_CLIENTE, NR_CPF_CLIENTE, NR_TELEFONE, NR_CELULAR, NR_TEL_ADICIONAL, DS_ENDERECO, NR_ENDERECO, DS_BAIRRO, DS_COMPLEMENTO, DS_CIDADE, DS_UF, NR_CEP FROM CLIENTE WHERE 1 = 1";

            if (filtros[0] != String.Empty)
            {
                Comando.CommandText += " AND NM_CLIENTE LIKE '%' +@Nome + '%' OR NR_TELEFONE LIKE '%' +@Nome + '%'  ";
                Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = filtros[0];
            }

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            List<Cliente> Clientes = new List<Cliente>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(Dr["ID_CLIENTE"]);
                    cliente.Nome = Convert.ToString(Dr["NM_CLIENTE"]);
                    cliente.CPF = Convert.ToString(Dr["NR_CPF_CLIENTE"]);
                    cliente.Telefone = Convert.ToString(Dr["NR_TELEFONE"]);
                    cliente.Celular = Convert.ToString(Dr["NR_CELULAR"]);
                    cliente.TelAdicional = Convert.ToString(Dr["NR_TEL_ADICIONAL"]);
                    cliente.Endereco = Convert.ToString(Dr["DS_ENDERECO"]);
                    cliente.Numero = Convert.ToString(Dr["NR_ENDERECO"]);
                    cliente.Bairro = Convert.ToString(Dr["DS_BAIRRO"]);
                    cliente.Complemento = Convert.ToString(Dr["DS_COMPLEMENTO"]);
                    cliente.Cidade = Convert.ToString(Dr["DS_CIDADE"]);
                    cliente.UF = Convert.ToString(Dr["DS_UF"]);
                    cliente.CEP = Convert.ToString(Dr["NR_CEP"]);

                    Clientes.Add(cliente);
                }
            }

            return Clientes;
        }
        public static void ExcluirClienteDAL(int IdCliente)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE CLIENTE WHERE ID_CLIENTE = @IdCliente";
            Comando.Parameters.Add("IdCliente", SqlDbType.Int).Value = IdCliente;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
        public static Cliente BuscarClienteDAL(int CodigoCliente)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT ID_CLIENTE, NM_CLIENTE, NR_CPF_CLIENTE, NR_TELEFONE, NR_CELULAR, NR_TEL_ADICIONAL, DS_ENDERECO, NR_ENDERECO, DS_BAIRRO, DS_COMPLEMENTO, DS_CIDADE, DS_UF, NR_CEP FROM CLIENTE WHERE ID_CLIENTE = @IdCliente";
            Comando.Parameters.Add("IdCliente", SqlDbType.Int).Value = CodigoCliente;

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            Cliente cliente = new Cliente();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    cliente.Id = Convert.ToInt32(Dr["ID_CLIENTE"]);
                    cliente.Nome = Convert.ToString(Dr["NM_CLIENTE"]);
                    cliente.CPF = Convert.ToString(Dr["NR_CPF_CLIENTE"]);
                    cliente.Telefone = Convert.ToString(Dr["NR_TELEFONE"]);
                    cliente.Celular = Convert.ToString(Dr["NR_CELULAR"]);
                    cliente.TelAdicional = Convert.ToString(Dr["NR_TEL_ADICIONAL"]);
                    cliente.Endereco = Convert.ToString(Dr["DS_ENDERECO"]);
                    cliente.Numero = Convert.ToString(Dr["NR_ENDERECO"]);
                    cliente.Bairro = Convert.ToString(Dr["DS_BAIRRO"]);
                    cliente.Complemento = Convert.ToString(Dr["DS_COMPLEMENTO"]);
                    cliente.Cidade = Convert.ToString(Dr["DS_CIDADE"]);
                    cliente.UF = Convert.ToString(Dr["DS_UF"]);
                    cliente.CEP = Convert.ToString(Dr["NR_CEP"]);
                }
            }

            return cliente;
        }
        public static void AtualizarClienteDAL(Cliente cliente)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "UPDATE CLIENTE SET NM_CLIENTE = @Nome, NR_CPF_CLIENTE = @CPF, NR_TELEFONE = @Telefone, NR_CELULAR = @Celular, NR_TEL_ADICIONAL = @TelefoneAdicional, DS_ENDERECO = @Endereco, NR_ENDERECO = @Numero, DS_BAIRRO = @Bairro, DS_COMPLEMENTO = @Complemento, DS_CIDADE = @Cidade, DS_UF = @UF, NR_CEP = @CEP WHERE ID_CLIENTE = @IdCliente";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = cliente.Nome;
            Comando.Parameters.Add("CPF", SqlDbType.VarChar).Value = cliente.CPF;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = cliente.Telefone;
            Comando.Parameters.Add("Celular", SqlDbType.VarChar).Value = cliente.Celular;
            Comando.Parameters.Add("TelefoneAdicional", SqlDbType.VarChar).Value = cliente.TelAdicional;
            Comando.Parameters.Add("Endereco", SqlDbType.VarChar).Value = cliente.Endereco;
            Comando.Parameters.Add("Numero", SqlDbType.VarChar).Value = cliente.Numero;
            Comando.Parameters.Add("Bairro", SqlDbType.VarChar).Value = cliente.Bairro;
            Comando.Parameters.Add("Complemento", SqlDbType.VarChar).Value = cliente.Complemento;
            Comando.Parameters.Add("Cidade", SqlDbType.VarChar).Value = cliente.Cidade;
            Comando.Parameters.Add("UF", SqlDbType.VarChar).Value = cliente.UF;
            Comando.Parameters.Add("CEP", SqlDbType.VarChar).Value = cliente.CEP;
            Comando.Parameters.Add("IdCliente", SqlDbType.Int).Value = cliente.Id;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }

        public static int InserirProdutoDAL(Produto produto)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT PRODUTOS (DS_PRODUTO, VR_VENDA, DS_CATEGORIA) VALUES (@DescricaoProduto, @Preco, @Categoria)";
            Comando.Parameters.Add("DescricaoProduto", SqlDbType.VarChar).Value = produto.DescricaoProduto;
            Comando.Parameters.Add("Preco", SqlDbType.VarChar).Value = produto.Preco;
            Comando.Parameters.Add("Categoria", SqlDbType.VarChar).Value = produto.Categoria;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(COD_PRODUTO) FROM PRODUTOS";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }
        public static List<Produto> BuscarProdutoDAL(string[] filtros)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "SELECT COD_PRODUTO, DS_PRODUTO, VR_VENDA, DS_CATEGORIA FROM PRODUTOS WHERE 1 = 1";

            if (filtros[0] != String.Empty)
            {
                Comando.CommandText += " AND DS_PRODUTO LIKE '%' +@Descricao + '%' ";
                Comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = filtros[0];
            }

            if (filtros[1] != String.Empty)
            {
                Comando.CommandText += " AND DS_CATEGORIA LIKE '%' +@Categoria + '%' ";
                Comando.Parameters.Add("Categoria", SqlDbType.VarChar).Value = filtros[1];
            }

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            List<Produto> Produtos = new List<Produto>();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Produto produto = new Produto();
                    produto.CodProduto = Convert.ToInt32(Dr["COD_PRODUTO"]);
                    produto.DescricaoProduto = Convert.ToString(Dr["DS_PRODUTO"]);
                    produto.Preco = Convert.ToString(Dr["VR_VENDA"].ToString());
                    produto.Categoria = Convert.ToString(Dr["DS_CATEGORIA"]);


                    Produtos.Add(produto);
                }
            }

            return Produtos;
        }
        public static void AtualizarProdutoDAL(Produto produto)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "UPDATE PRODUTOS SET DS_PRODUTO = @Descricao, VR_VENDA = @Preco, DS_CATEGORIA = @Categoria WHERE COD_PRODUTO = @CodProduto";
            Comando.Parameters.Add("Descricao", SqlDbType.VarChar).Value = produto.DescricaoProduto;
            Comando.Parameters.Add("Preco", SqlDbType.VarChar).Value = produto.Preco;
            Comando.Parameters.Add("CodProduto", SqlDbType.Int).Value = produto.CodProduto;
            Comando.Parameters.Add("Categoria", SqlDbType.VarChar).Value = produto.Categoria;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
        public static void ExcluirProdutoDAL(int CodigoProduto)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "DELETE PRODUTOS WHERE COD_PRODUTO = @CodigoProduto";
            Comando.Parameters.Add("CodigoProduto", SqlDbType.Int).Value = CodigoProduto;

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
        public static Produto BuscarProdutoDAL(int CodigoProduto)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "SELECT COD_PRODUTO, DS_PRODUTO, VR_VENDA, DS_CATEGORIA FROM PRODUTOS WHERE COD_PRODUTO = @CODPRODUTO";
            Comando.Parameters.Add("CODPRODUTO", SqlDbType.Int).Value = CodigoProduto;

            Conexao.Open();
            SqlDataReader Dr = Comando.ExecuteReader();

            Produto Produto = new Produto();

            if (Dr.HasRows)
            {
                while (Dr.Read())
                {
                    Produto.CodProduto = Convert.ToInt32(Dr["COD_PRODUTO"]);
                    Produto.DescricaoProduto = Convert.ToString(Dr["DS_PRODUTO"]);
                    Produto.Preco = Convert.ToString(Dr["VR_VENDA"]);
                    Produto.Categoria = Convert.ToString(Dr["DS_CATEGORIA"]);

                }
            }

            return Produto;
        }

        public static int InserirPedidoDAL(Pedido pedido)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT PEDIDOS (COD_CLIENTE_PEDIDO, VR_TOTAL_PEDIDO, OBS_PEDIDO) VALUES (@CodCliente, @VR_TOTAL_PEDIDO, @OBS_PEDIDO)";
            Comando.Parameters.Add("CodCliente", SqlDbType.VarChar).Value = pedido.CodCliente;
            Comando.Parameters.Add("VR_TOTAL_PEDIDO", SqlDbType.Real).Value = pedido.ValorTotalPedido;
            Comando.Parameters.Add("OBS_PEDIDO", SqlDbType.VarChar).Value = pedido.ObservacaoPedido;


            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(COD_PEDIDO) FROM PEDIDOS";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }

        public static int InserirItemDAL(Item_Venda item)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;

            Comando.CommandText = "INSERT ITENS_VENDAS (COD_PRODUTO) VALUES (@COD_PRODUTO)";
            Comando.Parameters.Add("COD_PRODUTO", SqlDbType.VarChar).Value = item.CodProduto;

            Conexao.Open();
            Comando.ExecuteNonQuery();

            Comando.CommandText = "SELECT MAX(COD_PEDIDO) FROM ITENS_VENDAS";
            return int.Parse(Comando.ExecuteScalar().ToString());
        }
    }
}
