using System.ComponentModel.DataAnnotations;

namespace sistemaValidacao.Model
{
    public class CadastroModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        public bool SoftDelete { get; set; }

        public UsuarioModel Usuario { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório.")]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "CNPJ inválido, deve conter 14 caracteres numéricos.")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        public string Tipo { get; set; }

        public SegmentoModel Segmento { get; set; }

        [Required(ErrorMessage = "O campo Enderecos é obrigatório.")]
        public List<EnderecoModel> Enderecos { get; set; }

    }
}
