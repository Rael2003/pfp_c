using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pfp_c.Models
{
    public class Funcionario
    {
        [JsonPropertyName("nome_completo")]
        public string NomeCompleto { get; set; } = string.Empty;

        [JsonPropertyName("data_de_nascimento")]
        public string? DataDeNascimento { get; set; }

        [JsonPropertyName("cpf")]
        public string Cpf { get; set; } = string.Empty;

        [JsonPropertyName("rg")]
        public string? Rg { get; set; }

        [JsonPropertyName("endereco_completo")]
        public string? EnderecoCompleto { get; set; }

        [JsonPropertyName("telefone_celular")]
        public string? TelefoneCelular { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("estado_civil")]
        public string? EstadoCivil { get; set; }

        [JsonPropertyName("cargo_funcao")]
        public string? CargoFuncao { get; set; }

        [JsonPropertyName("data_de_admissao")]
        public string? DataDeAdmissao { get; set; }

        [JsonPropertyName("salario")]
        public decimal? Salario { get; set; }

        [JsonPropertyName("regime_de_contratacao")]
        public string? RegimeDeContratacao { get; set; }

        [JsonPropertyName("numero_do_pis")]
        public string? NumeroDoPis { get; set; }

        [JsonPropertyName("banco")]
        public string? Banco { get; set; }

        [JsonPropertyName("agencia")]
        public string? Agencia { get; set; }

        [JsonPropertyName("conta_bancaria")]
        public string? ContaBancaria { get; set; }

        [JsonPropertyName("exame_admissional")]
        public DateTime? ExameAdmissional { get; set; }
    }
}
