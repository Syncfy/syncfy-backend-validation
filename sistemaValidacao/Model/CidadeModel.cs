using System.ComponentModel.DataAnnotations;

namespace sistemaValidacao.Model
{
    public class CidadeModel
    {
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CodIbge é obrigatório.")]
        public int CodIbge { get; set; }

        public EstadoModel Estado { get; set; }
    }
}
