using System;
using static System.Console;
using System.Globalization;
class CheckMonth2
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
        int dateChoice;

        Console.WriteLine("Enter a birth month number: ");
        monthChoice = int.Parse(Console.ReadLine());
        Month m = (Month)monthChoice;
        Console.WriteLine();
        Console.WriteLine("Enter the day of birth: ");
        dateChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if ((monthChoice < 1 || monthChoice > 12) && (dateChoice < 1 || dateChoice > 31))
        {
            Console.WriteLine("...really? its like you are not even trying at this point with entering a proper date -_- ");
        }
        else if (monthChoice == 2 && dateChoice > 29)
        {
            Console.WriteLine("February has up to 29 days, please put in a proper date within the month of February");
        }
        else if (monthChoice < 1 || monthChoice > 12)
        {
            Console.WriteLine("Invalid month entry, enter a number between 1 and 12.");
        }
        else if (dateChoice < 1 || dateChoice > 31)
        {
            Console.WriteLine("Months do not go over 31 days, please enter a proper day between 1 and 31 for your month");
        }
        else
        {
            Console.WriteLine("{0}/{1} is a valid birthday!",monthChoice, dateChoice);
        }
    }
}