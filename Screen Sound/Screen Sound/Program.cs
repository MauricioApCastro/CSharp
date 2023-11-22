void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

ExibirLogo();

Console.WriteLine("\nBem vindo ao Screen Sound!!\n");

void ExibirMenu()
{


    Console.WriteLine("Digite 1 para registrar sua Banda");


    Console.WriteLine("Digite 2 para mostrar todas as Bandas");


    Console.WriteLine("Digite 3 para avaliar uma Banda");


    Console.WriteLine("Digite 4 para exibir a média da sua Banda");

    Console.WriteLine("Digite -1 para sair");
}

ExibirMenu();

Console.Write("Digite a sua opção: ");
int numEscolha = int.Parse(Console.ReadLine()!);




switch (numEscolha)
{
    case 1:
        Console.WriteLine("Você escolheu a opção " + numEscolha);
        break;
    case 2:
        Console.WriteLine("Você escolheu a opção " + numEscolha);
        break;
    case 3:
        Console.WriteLine("Você escolheu a opção " + numEscolha);
        break;
    case 4:
        Console.WriteLine("Você escolheu a opção " + numEscolha);
        break;

}



