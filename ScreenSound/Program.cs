List<string> bands = new List<string>();

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
            ShowBands();
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
    bands.Add(bandName);
    Console.WriteLine("");
    Console.Write($"BANDA {bandName} SALVA COM SUCESSO!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowProgramName();
    ShowProgramMenu();
}

void ShowBands()
{
    Console.Clear();
    ShowProgramName();
    if (bands.Count > 0)
    {
        for (int index = 0; index < bands.Count; index++)
        {
            Console.WriteLine($"BANDA: {bands[index]} - AVALIAÇÃO MÉDIA: {0}");
        }
    }
    else
    {
        Console.WriteLine("NÃO HÁ BANDAS CADASTRADAS.");
    }
    Console.WriteLine("");
    Console.Write("PRESSIONE QUALQUER TECLA PARA RETORNAR AO MENU PRINCIPAL ...");
    Console.ReadLine();
    Console.Clear();
    ShowProgramName();
    ShowProgramMenu();
}