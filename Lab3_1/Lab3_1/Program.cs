using System.Security.Authentication;

namespace Lab3_1
{
    public static class Program
    {
        public static void Main()
        {
            Vector a = new Vector { X = 1, Y = 0.5f, Z = 4};
            Vector b = new Vector { X = 2.1f, Y = 6.2f, Z = -5};

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a * 4 = {a * 4}");
            Console.WriteLine($"4 * a = {4 * a}");

            Console.WriteLine($"a > b = {a > b}");
            Console.WriteLine($"a < b = {a < b}");
            Console.WriteLine($"a = b = {a == b}");


            Console.ReadKey();
        }
    }
}