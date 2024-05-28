

Produto produto = new("iPhone");

produto.PrecoUnitario = 5000;
produto.Descricao = "iPhone 14 Azul";
produto.Quantidade = 100;


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
void ExibirMenu(){
    ExibirLogo();
    Console.WriteLine("\n Digite 0 para sair");
    Console.WriteLine("\n Digite 1 para Adicionar produto");
    Console.WriteLine("\n Digite 2 para Listar todos os produtos");


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

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

void ExibirTitulo(string titulo)
{
    int qtdLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
    Console.WriteLine($"{asteriscos}\n{titulo}\n{asteriscos}");

}

void AdicionarProduto()
{
    Console.Clear();
    ExibirTitulo("Registro de Produto:");
    Console.Write("\nDigite o nome do produto: ");
    string produto = Console.ReadLine()!;
    Console.WriteLine($"O produto {produto} foi criado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
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


ExibirMenu();