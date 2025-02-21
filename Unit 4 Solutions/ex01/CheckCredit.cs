using System;
using static System.Console;
using System.Globalization;
class CheckCredit
{
    static void Main()
    {
        double credit;
        // Write your code here
        Console.WriteLine("Enter an amount to withdraw: ");
        credit = Convert.ToDouble(Console.ReadLine());

        if (credit > 8000 )
        {
            Console.WriteLine("You have exceeded the credit limit");
        }
        else
        {
            Console.WriteLine("Approved!");
        }
    }
}