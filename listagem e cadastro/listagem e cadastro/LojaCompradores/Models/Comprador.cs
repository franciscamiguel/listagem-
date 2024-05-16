using System.ComponentModel.DataAnnotations;

namespace SeuProjeto.Models
{
    public class Comprador
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string NomeRazaoSocial { get; set; }

        [Required]
        [StringLength(150)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefone { get; set; }

        public bool Bloqueado { get; set; }
    }
}
