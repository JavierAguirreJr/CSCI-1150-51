using System;
using static System.Console;
using System.Globalization;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
class SumInts
{
    static void Main()
    {
        // Write your code here
        int total = 0;
        int numInput;
        const int quit = 0;

        Console.WriteLine("Enter a interger: ");
        numInput = Convert.ToInt32(Console.ReadLine());

        while (numInput != quit && total < 999)
        {
            total += numInput;
            Console.WriteLine();
            Console.WriteLine("Enter another interger to be included to your previous total or press " + quit + " (zero) to quit.");            
            numInput = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("The final sum total of your inputs is: {0}", total);
    }
}
