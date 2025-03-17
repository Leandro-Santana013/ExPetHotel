// See https://aka.ms/new-console-template for more information
Console.Write("Espécie: ");
string especie = Console.ReadLine().ToUpper();
Console.Write("Raça: ");
string raca = Console.ReadLine().ToUpper();
Console.Write("Atende pela alcunha de: ");
string alcunha = Console.ReadLine();
Console.Write("Idade (em anos): ");
int idade = int.Parse(Console.ReadLine());
Console.Write("Pelagem/cor: ");
string pelagem = Console.ReadLine().ToUpper();

Console.Clear();

Console.WriteLine("+=========================================================+");
Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
Console.WriteLine("+=========================================================+");
Console.WriteLine("| " + ("Espécie: " + especie).PadRight(24, '.') +" | " + ("Raça: " + raca).PadRight(28, '.') + " |");
Console.WriteLine("+=========================================================+");
string prefixAlcunha = "Atende pela alcunha de: ";
int dotsCount = 57 - prefixAlcunha.Length - alcunha.Length;
Console.WriteLine("| " + prefixAlcunha + new string('.', dotsCount) + alcunha + " |");
Console.WriteLine("| " + ("Idade: " + idade.ToString("00") + " ano(s)").PadRight(26, ' ') + " | " + ("Pelagem/cor: " + pelagem).PadRight(28, '.') + " |");
 Console.WriteLine("+=========================================================+");
