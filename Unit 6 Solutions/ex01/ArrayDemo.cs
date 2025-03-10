using System;
using static System.Console;
using System.Globalization;
class ArrayDemo
{
    enum Menu
    {
        IN_ORIGINAL_ORDER = 1, REVERSE_ORDER, SPECIFIC_POSITION, QUIT
    }
    static void Main()
    {
        int[] nums = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
        // Write your code here
        Console.WriteLine("Select a particular option for the Array");
        Console.WriteLine("1 - In Order, 2 - Reverse Order, 3 - Specific Array position, 4 - Quit");
        int userInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (userInput == 1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        else if (userInput == 2)
        {
            Array.Reverse(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        else if (userInput == 3)
        {
            Console.WriteLine("Select a position in the Array you would like to access.");
            int arrayChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You select the position {0} which has a value of: " + nums[arrayChoice], arrayChoice);
        }
        else
        {
            Environment.Exit(0);
        }
    }
}