using System;
using static System.Console;
using System.Globalization;
class CheckMonth
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
        int monthChoice;

        Console.WriteLine("Enter a birth month number: ");
        monthChoice = int.Parse(Console.ReadLine());
        Month m = (Month)monthChoice;
        Console.WriteLine();

        if (monthChoice < 1 || monthChoice > 12)
        {
            Console.WriteLine("Invalid month entry, enter a number between 1 and 12.");
        }
        else
        {
            Console.WriteLine("{0} is a valid choice, that month is {1}!",monthChoice, m);
        }
        
    }
}