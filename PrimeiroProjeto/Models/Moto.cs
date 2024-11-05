namespace PrimeiroProjeto.Models
{
    public class Moto : Veiculo
    {
        public Moto()
        {
            QuantidadeRodas = 2;
            TanqueCombustivel = 20;
        }

        public int QuantidadeRodas { get; set; }

        public override void Acelerar()
        {
            InjetarCombustivel(1);
        }

        private void InjetarCombustivel(int quantidadeCombustivel)
        {
            base.TanqueCombustivel = base.TanqueCombustivel - quantidadeCombustivel;
        }
    }
}
