using System;
using static System.Console;
using System.Globalization;
class SubscriptExceptionTest
{
    static void Main()
    {
        // Write your code here
        double[] entries = new double[10];
        double input;
        try 
        {
            for (int i = 0; i < entries.Length; i++) 
            {
                Console.WriteLine("Enter a number to add to the index array or enter 99 to quit");
                input = Convert.ToDouble(Console.ReadKey());
                if (input != 99)
                {
                    Console.WriteLine(entries[i]);
                    Console.WriteLine("Entry has been added");
                }
                else
                {
                    Console.WriteLine("The inputs in the array are: " + entries[i]);
                }
            }
        }
        catch 
        {
            //index
            Console.WriteLine("Index was outside the bounds of the array.");
        }
    }
}