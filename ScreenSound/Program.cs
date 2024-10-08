﻿Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();

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
            EndProgram();
            break;
        case "1":
            RegisterNewBand();
            break;
        case "2":
            ShowBands();
            break;
        case "3":
            RateBand();
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
    bands.Add(bandName, new List<int> { });
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
        foreach (string band in bands.Keys)
        {
            if (bands[band].Count > 0)
            {
                Console.WriteLine($"BANDA: {band} - AVALIAÇÃO MÉDIA: {bands[band].Average()}");
            }
            else
            {
                Console.WriteLine($"BANDA: {band} - AVALIAÇÃO MÉDIA: S/A");
            }
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

void RateBand()
{
    Console.Clear();
    ShowProgramName();
    Console.Write("NOME DA BANDA: ");
    string bandName = Console.ReadLine()!;
    if (bands.ContainsKey(bandName))
    {
        Console.Write("NOTA: ");
        int rate = int.Parse(Console.ReadLine()!);
        bands[bandName].Add(rate);
        Console.WriteLine("");
        Console.Write($"NOTA SALVA COM SUCESSO!");
        Thread.Sleep(2000);
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("BANDA NÃO CADASTRADA.");
    }
    Console.Clear();
    ShowProgramName();
    ShowProgramMenu();
}

void EndProgram()
{
    Console.Clear();
    ShowProgramName();
    Console.WriteLine("");
    Console.Write("ENCERRANDO A APLICAÇÃO ...");
}