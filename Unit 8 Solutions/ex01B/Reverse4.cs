using System;
using static System.Console;
using System.Globalization;
class Reverse3
{
    static void Main()
    {
        // Write your code here
        int firstInt;
        int secondInt;
        int thirdInt;
        int fourthInt;

        firstInt = 23;
        secondInt = 45;
        thirdInt = 55;
        fourthInt = 67;

        Console.WriteLine("The numbers are {0}, {1}, {2}. {3}", firstInt, secondInt, thirdInt, fourthInt);
        Reverse(ref firstInt, ref secondInt, ref thirdInt, ref fourthInt);
        Console.WriteLine("The reversed numbers are {0}, {1}, {2}, {3}", firstInt, secondInt, thirdInt, fourthInt);

    }
    private static void Reverse(ref int first, ref int second, ref int third, ref int fourth)
    {
        first = 67;
        second = 55;
        third = 45;
        fourth = 23;
    }
}