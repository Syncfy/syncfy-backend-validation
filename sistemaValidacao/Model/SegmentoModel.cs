using System.ComponentModel.DataAnnotations;

namespace sistemaValidacao.Model
{
    public class SegmentoModel
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
    }
}
