using System;

namespace CarStorage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();
                Console.WriteLine("Enter cars name:");
                cars[i].Name = Console.ReadLine();

                Console.WriteLine("Enter cars price:");
                cars[i].Price = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter color of car:");
                cars[i].Color = Console.ReadLine();
            }
            Console.WriteLine($"Sourse price: {cars[0].Price}; Price after  sale: {cars[0].GetSale()}");

        }
    }
}