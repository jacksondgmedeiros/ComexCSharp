
namespace Comex.Modelos;

internal class Eletronico : Produto
{
    public Eletronico(string nome) : base(nome)
    {
    }

    public string Voltagem { get; set; }
    public string Potencia { get; set; }

}
