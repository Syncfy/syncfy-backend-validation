using System.ComponentModel.DataAnnotations;

namespace sistemaValidacao.Model
{
    public class EnderecoModel
    {
        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "CEP inválido, formato correto: 12345678.")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Numero é obrigatório.")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        public BairroModel Bairro { get; set; }
    }
}
