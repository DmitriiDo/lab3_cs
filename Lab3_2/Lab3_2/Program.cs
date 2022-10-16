namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car { Name = "Marsda", Engine = "v112", MaxSpeed = 100 };
            Car b = new Car { Name = "Ersedes", Engine = "rev 5", MaxSpeed = 100.2f };
            Car c = new Car { Name = "Laden", Engine = "eng 4", MaxSpeed = 100.1f };

            CarsCatalog catalog = new CarsCatalog { cars = { a, b, c } };

            Console.WriteLine("Cars in catalog");
            for(int i = 0; i < catalog.cars.Count; ++i)
            {
                Console.WriteLine(catalog.cars[i]);
            }

            Console.WriteLine($"car[0] == car[1] : {catalog.cars[0] == catalog.cars[1]}");
            Console.WriteLine($"car[0] == car[0] : {catalog.cars[0] == catalog.cars[0]}");

            Console.ReadKey();
        }
    }
}