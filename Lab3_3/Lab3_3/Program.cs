namespace Lab3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euro - rub ?");
            float euroToRub = float.Parse(Console.ReadLine());
            CurrencyEUR.ToRub = euroToRub;
            CurrencyRUB.ToEUR = 1 / euroToRub;

            Console.WriteLine("Euro - usd ?");
            float euroToUSD = float.Parse(Console.ReadLine());
            CurrencyEUR.ToUSD = euroToUSD;
            CurrencyUSD.ToEUR = 1 / euroToUSD;

            CurrencyRUB.ToUSD = CurrencyRUB.ToEUR * euroToUSD;
            CurrencyUSD.ToRub = 1 / CurrencyRUB.ToUSD;

            Console.WriteLine($"USD to rub {CurrencyUSD.ToRub}");
            Console.WriteLine($"Rub to usd {CurrencyRUB.ToUSD}");

            CurrencyUSD USD = new CurrencyUSD { Value = 10 };
            CurrencyEUR EUR = new CurrencyEUR { Value = 10 };
            CurrencyRUB RUB = new CurrencyRUB { Value = 10 };

            Console.WriteLine($"{USD.Value} USD to rub = {((CurrencyRUB)USD).Value}");
            Console.WriteLine($"{EUR.Value} EUR to rub = {((CurrencyRUB)EUR).Value}");

            Console.WriteLine($"{RUB.Value} RUB to USD = {((CurrencyUSD)RUB).Value}");
            Console.WriteLine($"{RUB.Value} RUB to EUR = {((CurrencyEUR)RUB).Value}");

            Console.ReadKey();
        }
    }
}