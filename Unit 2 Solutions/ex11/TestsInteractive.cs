using System;
using static System.Console;
using System.Globalization;
class TestsInteractive
{
    static void Main()
    {
        double scoreTest;
        // Write your code here
        Console.WriteLine("Enter 8 test scores to determine the average test score");
        Console.WriteLine("Enter the score for test 1");
        scoreTest = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the score for test 2");
        scoreTest += int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the score for test 3");
        scoreTest += int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the score for test 4");
        scoreTest += int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the score for test 5");
        scoreTest += int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the score for test 6");
        scoreTest += int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the score for test 7");
        scoreTest += int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the score for test 8");
        scoreTest += int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("The average test score is " + scoreTest/8);
        Console.Read();
    }
}