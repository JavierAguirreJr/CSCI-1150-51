using System;
using static System.Console;
using System.Globalization;
class SumFiveInts
{
    static void Main()
    {
        // Write your code here
        int numInput;

        Console.WriteLine("Enter 5 intergers to add up together.");
        numInput = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine("Enter another interger to add to the previous number");
            numInput += Convert.ToInt32(Console.ReadLine());
        }        
        Console.WriteLine("The sum total of the numbers you entered is {0}", numInput);
    }
}

