using System.ComponentModel.DataAnnotations;

namespace ProjetoBFP.Models
{
    public class Login
    {
        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string? Senha { get; set; }
    }
}
