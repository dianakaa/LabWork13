using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        string trimmed = inputString.Trim();

        string replaced = trimmed.Replace("  ", " ");

        Console.WriteLine("Обрезанная и замененная строка: " + replaced);

        Console.Write("Выберите регистр (1 - верхний, 2 - нижний, 3 - инвертированный): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                string upper = replaced.ToUpper();
                Console.WriteLine("Строка в верхнем регистре: " + upper);
                break;
            case 2:
                string lower = replaced.ToLower();
                Console.WriteLine("Строка в нижнем регистре: " + lower);
                break;
            case 3:
                StringBuilder inverted = new StringBuilder();
                foreach (char c in replaced)
                {
                    if (char.IsUpper(c))
                        inverted.Append(char.ToLower(c));
                    else
                        inverted.Append(char.ToUpper(c));
                }
                Console.WriteLine("Строка в инвертированном регистре: " + inverted.ToString());
                break;
            default:
                Console.WriteLine("Некорректный выбор регистра.");
                break;
        }
    }
}
