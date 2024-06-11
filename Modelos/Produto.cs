using System.Text.Json.Serialization;

namespace Comex.Modelos;

class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }
    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("description")]
    public string Descricao { get; set; }
    [JsonPropertyName("price")]
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; } 

    public void ExibirInformações()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Preço unitário: {PrecoUnitario}");
        Console.WriteLine($"Possui {Quantidade} Unidades\n");
    }
}

