using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Models;

namespace PrimeiroProjeto.Controllers
{
    [Route("api/aula11")]
    [ApiController]
    public class Aula11Controller : ControllerBase
    {
        [Route("obterVeiculo")]
        [HttpGet]
        public Veiculo obterVeiculo()
        {
            var meuVeiculo = new Veiculo();

            meuVeiculo.Cor = "Azul";
            meuVeiculo.Marca = "Volkswagen";
            meuVeiculo.Modelo = "Voyage";
            meuVeiculo.Placa = "IBF4J31";

            meuVeiculo.Acelerar();

            return meuVeiculo;
        }

        [Route("obterCarro")]
        [HttpGet]
        public Carro obterCarro()
        {
            var meuCarro = new Carro();

            meuCarro.Marca = "Honda";
            meuCarro.Modelo = "Fit";
            meuCarro.Placa = "DRT-2352";
            meuCarro.Cor = "Branco";

            return meuCarro;
        }

        [Route("obterMoto")]
        [HttpGet]
        public Moto obterMoto()
        {
            var minhaMoto = new Moto();

            minhaMoto.Marca = "Yamaha";
            minhaMoto.Modelo = "Fazer 250";
            minhaMoto.Cor = "Azul";
            minhaMoto.Placa = "EED-3523";

            return minhaMoto;
        }

    }
}
