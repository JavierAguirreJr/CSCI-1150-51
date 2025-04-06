using System;
using static System.Console;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
class TestClassifiedAd
{
    static void Main()
    {
        // Write your code here
        ClassifiedAd usedCars = new ClassifiedAd();
        ClassifiedAd helpWanted = new ClassifiedAd();

        usedCars.Category = "Used Cars";
        usedCars.Words = 100;

        helpWanted.Category = "Help Wanted";
        helpWanted.Words = 60;

        Console.WriteLine("The classified ad with {0} words in the category {1} costs {2}", usedCars.Words, usedCars.Category, usedCars.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        Console.WriteLine("The classified ad with {0} words in the category {1} costs {2}", helpWanted.Words, helpWanted.Category, helpWanted.Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));

    }
}
class ClassifiedAd
{
    public string Category { get; set; }
    public int Words { get; set; }
    public double Price { get { return Words * .09; }  }
}
