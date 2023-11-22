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
switch (escolha)
{
    case 1: Console.WriteLine("Você escolheu a opção " + escolha);
        break;
    case 2:
        Console.WriteLine("Você escolheu a opção " + escolha);
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

    
