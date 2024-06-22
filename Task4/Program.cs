namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient("Уличный Столб Фонарникович", "123456789", DateTime.Parse("2006/03/01"));
            Console.WriteLine(patient.ToString());
        }
    }
}
