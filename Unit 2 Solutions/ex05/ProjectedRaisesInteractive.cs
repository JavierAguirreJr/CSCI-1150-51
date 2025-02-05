using System;
using static System.Console;
using System.Globalization;
class ProjectedRaisesInteractive
{
    static void Main()
    {
        // Write your code here

        const decimal raise = 0.04m;

        Console.WriteLine("Enter the current employees salary: ");
        decimal emp = decimal.Parse(Console.ReadLine());
        Console.WriteLine();

        //WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("Next year's salary for the employee will be {0}", ((emp * raise) + emp).ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}