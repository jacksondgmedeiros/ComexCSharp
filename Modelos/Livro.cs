
namespace Comex.Modelos;

internal class Livro : Produto, IIdetificavel
{
    public Livro(string nome) : base(nome)
    {
    }

    public string Isbn { get; set; }
    public int TotalDePaginas { get; set; }

    public string Identificar()
    {
        return $"Livro: {Nome}, ISBN: {Isbn}";
    }

  
}
