using System.ComponentModel.DataAnnotations;

namespace aula.Areas.Seguranca.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}