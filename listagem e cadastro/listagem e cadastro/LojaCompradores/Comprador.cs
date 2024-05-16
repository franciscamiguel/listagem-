using System;

namespace LojaCompradores
{
    public class Comprador
    {
        public int Id { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Bloqueado { get; set; }
        public string Genero { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string TipoPessoa { get; set; }
        public string CPF_CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public bool Isento { get; set; }
        public string SenhaAcesso { get; set; }
    }
}
