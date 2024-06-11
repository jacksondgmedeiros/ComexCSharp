namespace Comex.Modelos;
class Cliente : IIdetificavel
{
    public Cliente(string nome, Endereco endereco)
    {
        Nome = nome;
        Endereco = endereco;
    }
    public string Nome { get;  }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }
    public Endereco Endereco { get; }

    public void DadosDoCliente()
    {
        Console.WriteLine($"O cliente {Nome} reside na cidade de {Endereco.Cidade}, localizado na rus {Endereco.Rua}");
    }

    public string Identificar()
    {
        return $" Nome: {Nome}, CPF: {Cpf}";
    }
}