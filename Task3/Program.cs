using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите текст: ");
        string inputText = Console.ReadLine();

        inputText = inputText.Trim();

        string pattern = @"\b\w+\b|[\,\.\s]+";

        string[] words = Regex.Split(inputText, pattern);

        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
                Console.WriteLine(word);
        }
    }
}
