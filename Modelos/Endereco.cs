namespace Comex.Modelos;
class Endereco()
{
    public Endereco(string cidade, string bairro, string estado, string rua, int numero, string complemento) :this()
    {
        Cidade = cidade;
        Bairro = bairro;
        Estado = estado;
        Rua = rua;
        Numero = numero;
        Complemento = complemento;
    }

    public string? Bairro { get; }
    public string? Cidade { get; }
    public string Complemento { get;  }
    public string Estado { get;  }
    public string Rua { get;  }
    public int Numero { get;  }
}