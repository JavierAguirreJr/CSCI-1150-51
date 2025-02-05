using System;
using static System.Console;
using System.Globalization;
class ProjectedRaises
{
    static void Main()
    {
        // Write your code here

        const decimal raise = 0.04m;
        decimal emp1 = 25000;
        decimal emp2 = 38000;
        decimal emp3 = 51000;

        Console.WriteLine("The current salary for the first employee is {0}", emp1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("The current salary for the second employee is {0}", emp2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("The current salary for the third employee is {0}", emp3.ToString("C", CultureInfo.GetCultureInfo("en-US")));

        Console.WriteLine();

        //WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("Next year's salary for the first employee will be {0}", ((emp1 * raise) + emp1).ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("Next year's salary for the second employee will be {0}", ((emp2 * raise) + emp2).ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("Next year's salary for the third employee will be {0}", ((emp3 * raise) + emp3).ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}