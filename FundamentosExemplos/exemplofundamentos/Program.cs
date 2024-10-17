string opcao;
string nome;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("1: Cadastrar Cliente");
    Console.WriteLine("2: Buscar Cliente");
    Console.WriteLine("3: Apagar registro");
    Console.WriteLine("4: Encerrar programa");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
        Console.WriteLine("Digite o nome do cliente");
        nome = Console.ReadLine();
        Console.WriteLine($"{nome} Cadastrado com Sucesso");
        break;
        case "2":
        Console.WriteLine("Busca de Cliente");
        break;
        case "3":
        Console.WriteLine("Registro apagado");
        break;
        case "4":
        Console.WriteLine("Encerrar programa");
        exibirMenu = false;
        break;
        default:
        Console.WriteLine("opção invalida");
        break;
        
    }
}

