using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
    static void Main()
    {
        // Write your code here
        const float baseRate = 200;
        const float hourRate = 150;
        const float mileRate = 2;
        float estimatePrice;

        Console.WriteLine("Welcome to Malcolm Movers, this prompt will provide an estimate based on your inputs.");
        Console.WriteLine("All moves incur a base fee of $200.");
        Console.WriteLine();
        Console.WriteLine("First, how many hours will your move require? (Hourly rate is $150)");
        float hoursTotal = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Next, how many miles of travel will be required? (Mileage is charged at $2");
        float milesTotal = float.Parse(Console.ReadLine());
        Console.WriteLine();
        estimatePrice = baseRate + (hourRate*hoursTotal) + (mileRate*milesTotal);
        Console.WriteLine("**For a move taking {0} hours and going {1} miles, the estimate is {2}**",hoursTotal,milesTotal,estimatePrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}