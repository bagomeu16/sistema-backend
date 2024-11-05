using System;

public class Veiculo
{
    //construtor
    public Veiculo()
    {
        TanqueCombustivel = 40;
    }

    //atributos/propriedades
    public string Cor { get; set; }

    public string Marca { get; set; }

    public string Placa { get; set; }

    public string Modelo { get; set; }

    public int TanqueCombustivel { get; set; }

    //métodos
    public virtual void Acelerar()
    {
        InjetarCombustivel(2);
    }

    public virtual void Frear()
    {

    }

    private void InjetarCombustivel(int quantidadeCombustivel)
    {
        TanqueCombustivel = TanqueCombustivel - quantidadeCombustivel;
    }
}
