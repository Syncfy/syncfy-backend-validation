namespace sistemaValidacao.Model
{
    public class EnderecoModel
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public BairroModel Bairro { get; set; }
    }
}
