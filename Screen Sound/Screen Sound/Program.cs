// Screen Sound
void ExibirMensagemBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\nBem Vindo ao Screen Sound!!\n");
}
void ExibirOpcoesMenu()
{

    Console.WriteLine("Digite 1 para registrar sua banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média da sua banda");
    Console.WriteLine("Digite 5 para sair");

}


ExibirMensagemBoasVindas();

ExibirOpcoesMenu();

Console.Write("Digite sua opção: ");
int escolha = int.Parse(Console.ReadLine()!);
List<string> listaBandas = new List<string>();    

switch (escolha)
{
    case 1:
        RegistrarBanda();
        break;
    case 2:
        MostrarBandasRegistradas();
        break;
    case 3:
        Console.WriteLine("Você escolheu a opção " + escolha);
        break;
    case 4:
        Console.WriteLine("Você escolheu a opção " + escolha);
        break;
    case 5:
        Console.WriteLine("");
        break;
        default: Console.WriteLine("opção inválida");
        break;
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar");
    string nomeDaBanda = Console.ReadLine()!;
    listaBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso! ");
    Thread.Sleep( 2000 );
    Console.Clear() ;
    ExibirMensagemBoasVindas() ;
    ExibirOpcoesMenu() ;
}

    void MostrarBandasRegistradas()
{
    Console.Clear();

}
