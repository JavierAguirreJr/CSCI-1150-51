using System;
using static System.Console;
using System.Globalization;
class HoursAndMinutes
{
    static void Main()
    {
        // Write your code here
        int minuteConvert;
        int hourConvert;

        Console.WriteLine("Enter the amount of minutes to convert: ");
        int minuteInput = int.Parse(Console.ReadLine());
        Console.WriteLine();

        hourConvert = minuteInput / 60;
        minuteConvert = minuteInput % 60;

        Console.WriteLine("{0} minutes is {1} hours and {2} minutes.", minuteInput, hourConvert, minuteConvert);

    }
}