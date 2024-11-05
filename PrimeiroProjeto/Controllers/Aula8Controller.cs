using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;


namespace PrimeiroProjeto.Controllers
{
    [Route("api/aula8")]
    [ApiController]
    public class Aula8Controller : ControllerBase
    {
        [Route("olaMundo")]
        [HttpGet]
        public string OlaMundo()
        {
            var mensagem = "Olá Mundo via API";

            return mensagem;
        }

        [Route("olaMundoPersonalizado")]
        [HttpGet]
        public string OlaMundoPersonalizado(string nome)
        {
            var mensagem = "Olá " + nome + " eu sou uma API";

            return mensagem;
        }

        [Route("somar")]
        [HttpGet]
        public string Somar(int valor1, int valor2)
        {
            var soma = valor1 + valor2;

            var mensagem = "A soma é " + soma;

            return mensagem;
        }

        [Route("media")]
        [HttpGet]
        public string Media(int valor1, int valor2)
        {
            var soma = (valor1 + valor2) / 2;

            var mensagem = "A média é " + soma;

            return mensagem;
        }

        [Route("terreno")]
        [HttpGet]
        public string Terreno(int comprimento, int largura, int m2)
        {
            var area = comprimento * largura;

            var valorTerreno = area * m2;

            var mensagem = "A área do terreno é " + area + "m2 e seu valor total é de R$ " + valorTerreno;

            return mensagem;
        }

        [Route("troco")]
        [HttpGet]
        public string Troco(float precoUnitario, int quantidade, int dinheiroRecebido)
        {
            var soma = precoUnitario * quantidade;

            var troco = dinheiroRecebido - soma;

            var mensagem = "Seu troco é R$" + troco;

            return mensagem;
        }

        [Route("pagamento")]
        [HttpGet]
        public string Pagamento(float valorHora, float quantidadeHoras, string nome)
        {
            var salario = valorHora * quantidadeHoras;

            var mensagem = "O pagamento para " + nome + " deve ser de R$" + salario;

            return mensagem;
        }

        [Route("consumo")]
        [HttpGet]
        public string Consumo(float litros, float distancia)
        {
            var consumo = distancia / litros;

            var mensagem = "O consumo médio do veículo é de " + consumo + "Km por litro";

            return mensagem;
        }
    }
}
