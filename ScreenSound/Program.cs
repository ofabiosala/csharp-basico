ShowProgramName();

ShowProgramMenu();

string optionSelected = Console.ReadLine()!;

if (optionSelected == "1")
{
    Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
}

if (optionSelected == "2")
{
    Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
}

if (optionSelected == "3")
{
    Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
}

if (optionSelected == "0")
{
    Console.WriteLine("OPÇÃO " + optionSelected + " SELECIONADA.");
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