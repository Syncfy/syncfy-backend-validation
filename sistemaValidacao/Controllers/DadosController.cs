using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using sistemaValidacao.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace sistemaValidacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DadosController : Controller
    {
        [HttpPost]
        public IActionResult ValidarCadastro([FromBody] CadastroModel cadastro)
        {
            List<string> mensagensErro = ValidarDados(cadastro);

            if (mensagensErro.Count > 0)
            {
                return BadRequest(new { Valid = false, Erros = mensagensErro });
            }
            return Ok(new { Valid = true });
        }

        private List<string> ValidarDados(CadastroModel cadastro)
        {
            List<string> mensagensErro = new List<string>();

            if (string.IsNullOrEmpty(cadastro.CNPJ) || !Regex.IsMatch(cadastro.CNPJ, @"^\d{14}$"))
            {
                mensagensErro.Add("CNPJ inválido, deve conter 14 caracteres numéricos");
            }

            if (string.IsNullOrEmpty(cadastro.Email) || !Regex.IsMatch(cadastro.Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                mensagensErro.Add("Email inválido");
            }

            if (string.IsNullOrEmpty(cadastro.Usuario?.Nome))
            {
                mensagensErro.Add("Nome do usuário é obrigatório");
            }

            if (string.IsNullOrEmpty(cadastro.Usuario?.Senha))
            {
                mensagensErro.Add("Senha do usuário é obrigatória");
            }

            if (string.IsNullOrEmpty(cadastro.Nome))
            {
                mensagensErro.Add("Nome da empresa é obrigatório");
            }

            if (string.IsNullOrEmpty(cadastro.Tipo))
            {
                mensagensErro.Add("Tipo é obrigatório");
            }

            if (string.IsNullOrEmpty(cadastro.Segmento?.Nome))
            {
                mensagensErro.Add("Nome do segmento é obrigatório");
            }

            if (string.IsNullOrEmpty(cadastro.Endereco?.CEP) || !Regex.IsMatch(cadastro.Endereco.CEP, @"^\d{8}$"))
            {
                mensagensErro.Add("CEP inválido, deve conter 8 caracteres numéricos");
            }

            if (string.IsNullOrEmpty(cadastro.Endereco?.Logradouro))
            {
                mensagensErro.Add("Logradouro é obrigatório");
            }

            if (string.IsNullOrEmpty(cadastro.Endereco?.Numero))
            {
                mensagensErro.Add("Número é obrigatório");
            }

            if (string.IsNullOrEmpty(cadastro.Endereco?.Bairro?.Nome))
            {
                mensagensErro.Add("Bairro é obrigatório");
            }

            if (string.IsNullOrEmpty(cadastro.Endereco?.Bairro?.Cidade?.Nome))
            {
                mensagensErro.Add("Cidade é obrigatória");
            }

            if (string.IsNullOrEmpty(cadastro.Endereco?.Bairro?.Cidade?.Estado?.Nome))
            {
                mensagensErro.Add("Estado é obrigatório");
            }

            if (string.IsNullOrEmpty(cadastro.Endereco?.Bairro?.Cidade?.Estado?.Pais?.Nome))
            {
                mensagensErro.Add("País é obrigatório");
            }

            return mensagensErro;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
