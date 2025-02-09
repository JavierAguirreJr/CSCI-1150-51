using System;
using static System.Console;
using System.Globalization;
class FahrenheitToCelsius
{
    static void Main()
    {
        // Write your code here
        double subtractor = 32;
        double multiplier = 5.0 / 9.0;
        double userInput;
        double celsius;

        Console.WriteLine("Enter a number to conver to Celsius including tenths (88.5)");
        userInput = double.Parse(Console.ReadLine());
        Console.WriteLine();
        celsius = (userInput -  subtractor) * multiplier;
        Console.WriteLine(userInput + "F is " + celsius + " C");
        Console.Read();
    }
}