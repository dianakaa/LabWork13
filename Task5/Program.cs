namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = ["meow", "Мяу", "Котики", "повелители", "мира"];

            Console.Write("Введите текст для поиска: ");
            string search = Console.ReadLine();

            foreach (string str in stringArray)
            {
                if (str.Contains(search))
                {
                    Console.WriteLine(str);
                }
            }

            if (!stringArray.Any(str => str.Contains(search)))
            {
                Console.WriteLine("Совпадение не найдено.");
            }
        }
    }

}

