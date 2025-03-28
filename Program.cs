using System.Reflection;
Console.Clear();

string especie = "", raca = "", alcunha = "", pelagem = "";
byte idade = 00;


Console.WriteLine("Pet Hotel Floquinho -- Check-in ");

Console.WriteLine("Digite a espécie:");
especie = Console.ReadLine()!;

Console.WriteLine("Digite a raça:");
raca = Console.ReadLine()!;

Console.WriteLine("Digite a alcunha:");
alcunha = Console.ReadLine()!;

Console.WriteLine("Digite a idade:");
idade = byte.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a pelagem/ cor:");
pelagem = Console.ReadLine()!;
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("+=========================================================+");
Console.Write("|                  ");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Pet Hotel Floquinho");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("                    |");
Console.WriteLine("+=========================================================+");
Console.Write("| ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"Espécie: {especie.PadLeft(15,'.').ToUpper()}");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write(" | ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"Raça: {raca.PadLeft(18,'.').ToUpper()}");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("     |");
Console.WriteLine("+=========================================================+");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"Atende pela alcunha de: {alcunha.PadLeft(25,'.').ToUpper()}");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("        |");
Console.Write("|");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"Idade: {idade.ToString("00")} ano(s) | Pelagem/cor: {pelagem.PadLeft(15,'.').ToUpper()}");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("          |");
Console.Write("+=========================================================+");
Console.ResetColor();
