using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
    enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    static void Main()
    {
        // Write your code here
        double interiorCost;
        double exteriorCost;
        double interiorWalls;
        double exteriorWalls;
        double total;
        int monthChoice;

        Console.WriteLine("Enter the month for your project: ");
        monthChoice = int.Parse(Console.ReadLine());
        Month m = (Month)monthChoice;
        Console.WriteLine();
        Console.WriteLine("Enter number of interior murals scheduled: ");
        interiorWalls = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter number of exterior murals scheduled: ");
        exteriorWalls = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (monthChoice == 1 || monthChoice == 2 || monthChoice == 12)
        {
            exteriorWalls = 0;
            exteriorCost = 0;
            Console.WriteLine("You selected {0} for your month, because of uncertain weather conditions, exterior murals cannot be painted in December through February.", m);
        }
        else if (monthChoice == 4 || monthChoice == 5 || monthChoice == 9 || monthChoice == 10) 
        {
            exteriorCost = 699;
            Console.WriteLine("You selected {0} for your month, Marshall prefers to paint exterior murals in April, May, September, and October.", m) ;
            Console.WriteLine("To encourage business, a special pricing of $699 is used during these months.");
        }
        else
        {
            exteriorCost = 750;
        }

        if (monthChoice == 7 || monthChoice == 8)
        {
            interiorCost = 450;
        }
        else 
        {
            interiorCost = 500;
        }

        Console.WriteLine();
        Console.WriteLine("{0} interior murals are scheduled at {1} each for a total of {2}", interiorWalls, interiorCost.ToString("C", CultureInfo.GetCultureInfo("en-US")), (interiorCost * interiorWalls).ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("{0} exterior murals are scheduled at {1} each for a total of {2}", exteriorWalls, exteriorCost.ToString("C", CultureInfo.GetCultureInfo("en-US")), (exteriorCost * exteriorWalls).ToString("C", CultureInfo.GetCultureInfo("en-US")));
        total = (interiorWalls * interiorCost) + (exteriorWalls * exteriorCost);
        Console.WriteLine("Total revenue expected is {0}", total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine();
        if (interiorWalls > exteriorWalls)
        {
            Console.WriteLine("It is TRUE that there are more interior murals scheduled than exterior ones.");
        }
        else
        {
            Console.WriteLine("It is FALSE that there are more exterior murals schedules than interior ones.");
        }

    }
}