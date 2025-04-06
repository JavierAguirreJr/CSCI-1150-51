// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using System;
using static System.Console;
using System.Globalization;
class DebugNine2
{
    static void Main()
    {
        Breakfast special = new Breakfast() { Name = "French Toast", Price = 4.99};
        //Display the info about breakfast
        WriteLine(special.INFO);
        // then display today's special
        WriteLine("Today we are having {0} for {1}",
           special.Name, special.Price.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
    }
}
public class Breakfast
{
    public string INFO =
       "Breakfast is the most important meal of the day.";

    // Breakfast constructor requires a
    // name, e.g "French toast", and a price
    //public Breakfast(string name, double price)
    //{
    //    name = "French toast";
    //    price = 4.99;
    //}
    public string Name { get; set; }
    public double Price { get; set; }
}
