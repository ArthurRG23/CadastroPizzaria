using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pedido
    {
        public int CodPedido { get; set; }
        public int CodCliente { get; set; }
        public string NomeCliente { get; set; }
        public float ValorTotalPedido { get; set; }
        public string ObservacaoPedido { get; set; }
    }
}
