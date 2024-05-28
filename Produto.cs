class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;  }
    public string Descricao { get; set; }
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

