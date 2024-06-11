

using Comex.Modelos;

namespace Comex.Linq;

internal class Linq
{

    public static void ExibirDados(List<Produto> produtos)
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine($"{produto.ExibirInformações}");
            Console.WriteLine($"\nNome: {produto.Nome} \nDescrição: {produto.Descricao}\nPreço: {produto.PrecoUnitario}");

        }
    }

    public static void ExibirDadosOrdenadosNome(List<Produto> produtos)
    {
       var produtosOrdenados = produtos.OrderBy(produto => produto.Nome).Select(produto => produto.Nome).Distinct().ToList();
       Console.WriteLine("Lista de produtos ordenadas:");
        foreach (var produto in produtosOrdenados)
        {
            Console.WriteLine($"- Nome: {produto}");
        }

    }

    public static void ExibirDadosOrdenadosPreco(List<Produto> produtos)
    {
        var produtosOrdenados = produtos.OrderBy(produto => produto.PrecoUnitario).Select(produto => produto.PrecoUnitario).ToList();
        Console.WriteLine("Lista de produtos ordenadas pelo Preço:");
        foreach (var produto in produtosOrdenados)
        {
            Console.WriteLine($"- Preço: {produto}");
        }
    }
}
