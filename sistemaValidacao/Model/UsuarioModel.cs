using System.ComponentModel.DataAnnotations;

namespace sistemaValidacao.Model
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string Senha { get; set; }
    }
}
