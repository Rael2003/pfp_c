using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pfp_c.Models
{
    public class ProjetoAtribuicaoDTO
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string EmpresaCliente { get; set; }
        public long EmpresaClienteId { get; set; }
        public string FuncionarioResponsavel { get; set; }
        public long? FuncionarioResponsavelId { get; set; }
        public string NomeProjeto { get; set; }
        public string Status { get; set; }
        public long ProjetoItemId { get; set; }
        public string Titulo_item { get; set; }
        public int Quantidade { get; set; }
    }
}
