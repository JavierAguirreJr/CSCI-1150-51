using System;
using static System.Console;
using System.Globalization;
class Admission
{
    static void Main()
    {
        // Write your code here
        double gpa;
        int testScore;

        Console.WriteLine("Enter the students GPA score: ");
        gpa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the students admission test score: ");
        testScore = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (gpa >= 3 &&  testScore >= 60 || gpa < 3 && testScore >= 80)
        {
            Console.WriteLine("Accept!");
        }
        else
        {
            Console.WriteLine("Reject!");
        }
    }
}