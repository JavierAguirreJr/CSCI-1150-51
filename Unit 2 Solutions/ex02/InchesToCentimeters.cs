using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
    static void Main()
    {
        // Write your code here

        const double cm = 2.54;
        double inchTotal = 3;

        Console.WriteLine("** " + inchTotal + " inches is " + (inchTotal*cm) + " centimeters**");
    }
}