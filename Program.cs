using System;

namespace HouseTaxCalcSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the address:");
            string address = Console.ReadLine();

            Console.WriteLine("Enter the number of rooms:");
            int rooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of bathrooms:");
            int bathrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the property value:");
            decimal propertyValue = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the municipal rate (example 0.006):");
            decimal municipalRate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the property reduction:");
            decimal propertyReduction = decimal.Parse(Console.ReadLine());

            // Create House Object
            House house = new House(address, rooms, bathrooms, propertyValue, municipalRate, propertyReduction);

            // Print details
            house.PrintDetails();
        }
    }
}
