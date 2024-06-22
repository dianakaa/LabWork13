Console.WriteLine("Введите строку: ");
string inputString = Console.ReadLine();

int charCount = inputString.Length;
Console.WriteLine($"Количество символов: {charCount}");

int charCountWithoutSpaces = inputString.Replace(" ", "").Length;
Console.WriteLine($"Количество символов без пробелов: {charCountWithoutSpaces}");

int letterCount = 0;
for (int i = 0; i < inputString.Length; i++)
{
    if (char.IsLetter(inputString[i]))
    {
        letterCount++;
    }
}
Console.WriteLine($"Количество букв: {letterCount}");

Console.WriteLine("Введите символ для поиска: ");
char searchChar = (char)Console.Read();
for (int i = 0; i < inputString.Length; i++)
{
    if (inputString[i] == searchChar)
    {
        Console.WriteLine($"Символ '{searchChar}' найден в позиции {i}");
    }
}
if (!inputString.Contains(searchChar))
{
    Console.WriteLine($"Символ '{searchChar}' не найден во введенной строке");
}
