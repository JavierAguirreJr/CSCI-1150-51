using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
    static void Main()
    {
        // Write your code here

        const double cm = 2.54;

        Console.WriteLine("Enter a number to convert to inches: ");
        double inchTotal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("** " + inchTotal + " inches is " + (inchTotal*cm) + " centimeters**");
    }
}