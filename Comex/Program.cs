using Comex.Linq;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml;
using Comex.Modelos;


var listaPedidos = new List<Pedido>();

Produto produto = new("iPhone")
{
    PrecoUnitario = 5000,
    Descricao = "iPhone 14 Azul",
    Quantidade = 100
};


produto.ExibirInformações();


Endereco endereco = new("São Paulo", "Cambuci", "SP", "Rua das Flores", 100, "ap30");


Cliente cliente = new("Jackson Medeiros", endereco);

cliente.DadosDoCliente();



void ExibirLogo()
{
    Console.WriteLine(@"
    
────────────────────────────────────────────────────────────────────────────────────────
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██████████████░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██░░██████████─██░░██████░░██─██░░░░░░░░░░░░░░░░░░██─██░░██████████─████░░██──██░░████─
─██░░██─────────██░░██──██░░██─██░░██████░░██████░░██─██░░██───────────██░░░░██░░░░██───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░░░░░░░░░██─────██░░░░░░██─────
─██░░██─────────██░░██──██░░██─██░░██──██████──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──────────██░░██─██░░██───────────██░░░░██░░░░██───
─██░░██████████─██░░██████░░██─██░░██──────────██░░██─██░░██████████─████░░██──██░░████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──────────██░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
────────────────────────────────────────────────────────────────────────────────────────
    
    ");

    Console.WriteLine("Boas vindas ao projeto Comex!");
}

List<string> listaProodutos = [];
async Task ExibirMenu(){
    ExibirLogo();
    Console.WriteLine("\n Digite 0 para sair");
    Console.WriteLine("\n Digite 1 para Adicionar produto");
    Console.WriteLine("\n Digite 2 para Listar todos os produtos");
    Console.WriteLine("\n Digite 3 para Consulta de API Externa");
    Console.WriteLine("\n Digite 4 Criar Pedido");
    Console.WriteLine("\n Digite 5 Listar Pedidos");


    Console.Write("\n Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int converteOpcaoEscolhidaPorNumero = int.Parse(opcaoEscolhida);

    switch (converteOpcaoEscolhidaPorNumero)
    {
        case 0:
            Console.WriteLine("Você escolheu sair!");
            break;
        case 1:
            AdicionarProduto();
            break;
        case 2:
            ListarProdutos();
            break;
        case 3:
            await ConsultaApiExterna();
            break;
        case 4:
            await CriarPedidoAsync();
            break;
        case 5:
            await ListarPedidosAsync();
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

async Task ListarPedidosAsync()
{
   Console.Clear();
    Console.WriteLine("Litando os pedidos:");

    var pedidosOrdenados = listaPedidos.OrderBy(pedido => pedido.Cliente.Nome).ToList();

    foreach (var p in pedidosOrdenados)
    {
        Console.WriteLine($"Pedido: {p}");
        
    }

    Console.ReadKey();
    await ExibirMenu();
}

async Task CriarPedidoAsync()
{
    Console.Clear();
    Console.WriteLine("Criando um novo Pedido");
    Console.WriteLine("Digite o nome do CLiente");
    string nomeCLiente = Console.ReadLine()!;

    var cliente1 = new Cliente(nomeCLiente, endereco);

    Pedido pedido = new Pedido(cliente1);

    Console.WriteLine($"\n Produtos disponíveis: ");

    Console.WriteLine($" Produto: {produto.Nome}, Valor: {produto.PrecoUnitario}");

    Console.Write($"Digite a quantidade desejada: ");
    var quantidade = int.Parse( Console.ReadLine()!);

    ItemDePedido itemDePedido = new(produto, quantidade, (decimal)produto.PrecoUnitario);
    pedido.AdicionarItem(itemDePedido);
    Console.WriteLine("Item adicionado com sucesso!");
    Console.WriteLine(itemDePedido);
    listaPedidos.Add(pedido);
    Console.WriteLine(pedido);
    Console.WriteLine("pedido criado com sucesso!");

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();


    await ExibirMenu();

}

async Task ConsultaApiExterna()
{
    using (HttpClient client = new HttpClient())
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Consulta em API Externa\n");
          
            string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");

            var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta)!;

            Console.WriteLine("\n Digite 0 para voltar");
            Console.WriteLine("\n Digite 1 para Listar os produtos");
            Console.WriteLine("\n Digite 2 para Listar os produtos Ordenados por Nome");
            Console.WriteLine("\n Digite 3 para Listar os produtos ordenador por Preço");

            Console.Write("\n Digite sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int converteOpcaoEscolhidaPorNumero = int.Parse(opcaoEscolhida);

            

            switch (converteOpcaoEscolhidaPorNumero)
            {
                case 0:
                    Console.WriteLine("Você escolheu sair!");
                    break;
                case 1:
                    Linq.ExibirDados(produtos);
                    break;
                case 2:
                    Linq.ExibirDadosOrdenadosNome(produtos);
                    break;
                case 3:
                    Linq.ExibirDadosOrdenadosPreco(produtos);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            //Linq.ExibirDados(produtos);
            //Linq.ExibirDadosOrdenadosNome(produtos);
            //Linq.ExibirDadosOrdenadosPreco(produtos);

        }
        catch (Exception ex) {
            Console.WriteLine($"Temos um problema: {ex.Message}");
        }
    }
}

void ExibirTitulo(string titulo)
{
    int qtdLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
    Console.WriteLine($"{asteriscos}\n{titulo}\n{asteriscos}");

}

async void AdicionarProduto()
{
    Console.Clear();
    ExibirTitulo("Registro de Produto:");
    Console.Write("\nDigite o nome do produto: ");
    string produto = Console.ReadLine()!;
    Console.WriteLine($"O produto {produto} foi criado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    await ExibirMenu();
}

void ListarProdutos()
{
    Console.Clear();
    ExibirTitulo("Exibindo os Produtos cadastrados:");
    
    foreach (string produto in listaProodutos)
    {
        
        Console.WriteLine($"Nome: {produto}");
    }
}


await ExibirMenu();

/*
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
            Console.WriteLine(resposta);
    }
    catch
    {
        throw;
    }
}
*/