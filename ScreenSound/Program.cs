ShowProgramName();

ShowProgramMenu();

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

    string optionSelected = Console.ReadLine()!;

    switch (optionSelected)
    {
        case "0":
            Console.WriteLine("ENCERRANDO A APLICAÇÃO ...");
            break;
        case "1":
            RegisterNewBand();
            break;
        case "2":
            Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
            break;
        case "3":
            Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
            break;
        default:
            Console.WriteLine("OPÇÃO INVÁLIDA!");
            break;
    }
}

void RegisterNewBand()
{
    Console.Clear();
    ShowProgramName();
    Console.Write("NOME DA BANDA: ");
    string bandName = Console.ReadLine()!;
    Console.Write("");
    Console.Write($"BANDA {bandName} SALVA COM SUCESSO!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowProgramName();
    ShowProgramMenu();
}