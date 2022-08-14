internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Введите трехзначное число:");
        while (true)
        {
            string input = Console.ReadLine();
            if (!input.Equals("q"))
            Console.WriteLine("{0}->{1}", input, input[1]);
            else
            break;
        }
    }
}