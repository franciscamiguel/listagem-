using System;
using Microsoft.EntityFrameworkCore;

namespace LojaCompradores
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LojaContext())
            {
                // Exemplo de adição de um comprador
                var novoComprador = new Comprador
                {
                    NomeRazaoSocial = "Fulano de Tal",
                    Email = "fulano@example.com",
                    Telefone = "123456789",
                    DataCadastro = DateTime.Now,
                    Bloqueado = false,
                    Genero = "Masculino",
                    DataNascimento = new DateTime(1990, 1, 1),
                    TipoPessoa = "Física",
                    CPF_CNPJ = "123.456.789-00",
                    Isento = false,
                    SenhaAcesso = "senha123"
                };

                context.Compradores.Add(novoComprador);
                context.SaveChanges();

                // Exemplo de consulta de todos os compradores
                var compradores = context.Compradores;
                foreach (var comprador in compradores)
                {
                    Console.WriteLine($"Nome/Razão Social: {comprador.NomeRazaoSocial}, E-mail: {comprador.Email}, Telefone: {comprador.Telefone}, Data de Cadastro: {comprador.DataCadastro}");
                }
            }
        }
    }
}
