

namespace Comex.Modelos;

internal class ItemDePedido
{
    public ItemDePedido(Produto produto, int quantidade, decimal precoUnitario)
    {
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = precoUnitario;
        SubTotal = quantidade * precoUnitario;
    }

    public Produto Produto { get; private set; }
    public int Quantidade { get; private set; }
    public decimal PrecoUnitario { get; private set; }
    public decimal SubTotal { get; private set; }

    public override string ToString()
    {
        return $"Produto {Produto.Nome}, Quantidade {Quantidade}, Preço unitário {PrecoUnitario:F2}, Sub total {SubTotal}";
    }
}
