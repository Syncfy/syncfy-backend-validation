namespace sistemaValidacao.Model
{
    public class CadastroModel
    {
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public UsuarioModel Usuario { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public SegmentoModel Segmento { get; set; }
        public EnderecoModel Endereco { get; set; }

    }
}
