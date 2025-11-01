using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pfp_c.Models
{
    public class PedidoEstoqueDTO
    {
        public long Id { get; set; }
        public DateTime DataPedido { get; set; }
        public long ItemProjetoId { get; set; }
        public long ProdutoEstoqueId { get; set; }
        public int QuantidadeSolicitada { get; set; }
        public int QuantidadeAtendida { get; set; }
        public string Status { get; set; }
    }
}
