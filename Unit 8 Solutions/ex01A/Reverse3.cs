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

        firstInt = 23;
        secondInt = 45;
        thirdInt = 67;

        Console.WriteLine("The numbers are {0}, {1}, {2}", firstInt, secondInt, thirdInt);
        Reverse(ref firstInt, ref secondInt, ref thirdInt);
        Console.WriteLine("The reversed numbers are {0}, {1}, {2}", firstInt, secondInt, thirdInt);

    }
    private static void Reverse(ref int first, ref int second, ref int third)
    {
        first = 67;
        second = 45;
        third = 23;
    }
}