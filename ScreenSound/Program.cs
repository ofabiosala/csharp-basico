ShowProgramName();

ShowProgramMenu();

string optionSelected = Console.ReadLine()!;

switch (optionSelected)
{
    case "0":
        Console.WriteLine("ENCERRANDO A APLICAÇÃO ...");
        break;
    case "1":
        Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
        break;
    case "2":
        Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
        break;
    case "3":
        Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
        break;
    default:
        Console.WriteLine("OPÇÃO INVÁLIDA!");
        break ;
}

void ShowProgramName()
{
    string programName = @"

     ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
     ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
     ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
     ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
     ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
     ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

    ";

    Console.WriteLine(programName);
}

void ShowProgramMenu()
{
    Console.WriteLine("[1] - REGISTRAR BANDA");
    Console.WriteLine("[2] - EXIBIR BANDAS");
    Console.WriteLine("[3] - AVALIAR BANDA");
    Console.WriteLine("[0] - SAIR");

    Console.WriteLine("");

    Console.Write("DIGITE UMA OPÇÃO: ");
}