namespace Comex.Modelos;
internal class Pedido
{
    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        Data = DateTime.Now;
        Itens = new List<ItemDePedido>();
    }

    public Cliente Cliente { get; private set; }
    public DateTime Data { get; private set; }
    public List<ItemDePedido> Itens { get; private set; }
    public decimal Total { get; private set; }

    public void AdicionarItem(ItemDePedido item)
    {
        Itens.Add(item);
        Total += item.SubTotal;
    }

    public override string ToString()
    {
        return $"Cliente {Cliente.Nome}, data {Data}, Total {Total:F2}";
    }
}
