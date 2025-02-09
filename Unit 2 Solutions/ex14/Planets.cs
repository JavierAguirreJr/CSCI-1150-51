using System;
using static System.Console;
using System.Globalization;
class MonthNames
{
    enum Planet
    {
        Mercury = 1,
        Venus,
        Earth,
        Mars,
        Jupiter,
        Saturn,
        Uranus,
        Neptune,
        Pluto
    }
    static void Main()
    {
        // Write your code here
        int planetChoice;

        Console.WriteLine("Enter a number between 1-9 and learn the name and planets its away from the sun:");
        planetChoice = int.Parse(Console.ReadLine());
        Planet p = (Planet)planetChoice;

        Console.WriteLine();
        Console.WriteLine(p + " is " + planetChoice + " planet(s) from the sun.");
    }
}