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
        do
        {
            Console.WriteLine("Please enter a valid entry for number of contestants last year.");
            Console.WriteLine("Valid entry values are between 0 and 30.");
            Console.WriteLine();
            Console.WriteLine("Enter the number of contestants last year: ");
            lastYear = int.Parse(Console.ReadLine());
        }
        while (lastYear < 0 || lastYear > 30);
        
        Console.WriteLine();
        Console.WriteLine("Enter the number of contestants this year: ");
        thisYear = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Please enter a valid entry for number of contestants this year.");
            Console.WriteLine("Valid entry values are between 0 and 30.");
            Console.WriteLine();
            Console.WriteLine("Enter the number of contestants this year: ");
           thisYear = int.Parse(Console.ReadLine());
        }
        while (thisYear < 0 || thisYear > 30);

        Console.WriteLine();
        Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants.", lastYear, thisYear);
        Console.WriteLine("Revenue expected this year is {0}", (thisYear * entryFee).ToString("C", CultureInfo.GetCultureInfo("en-US")));

        if (lastYear * 2 < thisYear)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (lastYear < thisYear)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}