const int NumberOfNumbers = 9;
int[] numbers = new int[NumberOfNumbers];

Console.WriteLine($"==== Getal opvragen uit {NumberOfNumbers} ====\r\n\r\n");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Geef getal {i + 1}/{numbers.Length} : ");
    numbers[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}

Console.Write($"Welk getal van de {numbers.Length} getallen wens je opnieuw te zien? ");
int index = int.Parse(Console.ReadLine()) - 1;
if (index < 0 || index >= numbers.Length)
{
    Console.WriteLine("\r\n\r\n Dit is geen geldig hoeveelste getal!");
    return;
}
int numberAtIndex = numbers[index];
Console.WriteLine($"\r\n\r\nJouw getal is {numberAtIndex}");
Console.ReadLine();
