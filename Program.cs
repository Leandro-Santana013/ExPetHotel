// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a espécie do animal: "); 
string especie = Console.ReadLine();

Console.WriteLine("Digite a raça do animal: ");
string raca = Console.ReadLine();

Console.WriteLine("Atende pela alcunha de: ");
string alcunha = Console.ReadLine();

Console.WriteLine("Digite a idade do animal: ");
string idade = Console.ReadLine();

Console.WriteLine("Digite a pelagem/cor do animal: ");
string pelagem = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+===============================================================+");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|                    Pet Hotel \"Nem um pio\"                     |");

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+===============================================================+");

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(especie.ToUpper().Trim().PadLeft(15, '.').Substring(0, 15));

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(raca.ToUpper().Trim().PadLeft(28, '.').Substring(0, 28));

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.Gray; 
Console.WriteLine("+===============================================================+");

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("| Atende pela Alcunha de: ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(alcunha.ToUpper().Trim().PadLeft(37, '.').Substring(0, 37));

Console.ForegroundColor = ConsoleColor.Gray; 
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write($@"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");

Console.ForegroundColor = ConsoleColor.Gray; 
Console.Write(" | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(pelagem.Trim().ToUpper().PadLeft(29, '.').Substring(0, 29));

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("+===============================================================+");

Console.ResetColor();
