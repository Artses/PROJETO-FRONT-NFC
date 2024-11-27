using System.ComponentModel.DataAnnotations;

namespace ProjetoBFP.Models
{
    public class Cadastro
    {
        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um email válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres.")]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "Confirme sua senha.")]
        public string? ConfirmarSenha { get; set; }
    }
}
