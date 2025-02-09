using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
    static void Main()
    {
        // Write your code here
        int lastYear;
        int thisYear;
        int entryFee = 25;

        Console.WriteLine("Enter the number of contestants last year: ");
        lastYear = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the number of contestants this year: ");
        thisYear = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants.",lastYear, thisYear);
        Console.WriteLine("Revenue expected this year is {0}", (thisYear*entryFee).ToString("C", CultureInfo.GetCultureInfo("en-US")));

        if (lastYear < thisYear)
        {
            Console.WriteLine("It is TRUE that this year's competition is bigger than last year's.");
        }
        else
        {
            Console.WriteLine("Unfortunately this year's competition wont be bigger than last year's.");
        }
    }
}