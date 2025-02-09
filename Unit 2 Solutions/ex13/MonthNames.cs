using System;
using static System.Console;
using System.Globalization;
class MonthNames
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

        Console.WriteLine("Enter the number of a month and we will show you the name of that month");
        monthChoice = int.Parse(Console.ReadLine());
        Month m = (Month)monthChoice;

        Console.WriteLine();
        Console.WriteLine("Your month is: " + m );
    }
}