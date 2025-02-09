using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
    static void Main()
    {
        // Write your code here
        double interiorCost = 500;
        double exteriorCost = 750;
        double interiorWalls;
        double exteriorWalls;
        double total;

        Console.WriteLine("Enter number of interior murals scheduled: ");
        interiorWalls = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter number of exterior murals scheduled: ");
        exteriorWalls = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("{0} interior murals are scheduled at {1} each for a total of {2}", interiorWalls, interiorCost.ToString("C",CultureInfo.GetCultureInfo("en-US")),(interiorCost*interiorWalls).ToString("C",CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("{0} exterior murals are scheduled at {1} each for a total of {2}", exteriorWalls, exteriorCost.ToString("C", CultureInfo.GetCultureInfo("en-US")), (exteriorCost * exteriorWalls).ToString("C", CultureInfo.GetCultureInfo("en-US")));
        total = (interiorWalls*interiorCost) + (exteriorWalls*exteriorCost);
        Console.WriteLine("Total revenue expected is {0}", total.ToString("C",CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine();

        if (interiorWalls > exteriorWalls)
        {
            Console.WriteLine("It is TRUE that there are more interior murals scheduled than exterior ones.");
        }
        else
        {
            Console.WriteLine("It is TRUE that there are more exterior murals schedules than interior ones.");
        }
    }
}