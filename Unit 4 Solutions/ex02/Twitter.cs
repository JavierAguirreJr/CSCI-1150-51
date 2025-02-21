using System;
using static System.Console;
using System.Globalization;
class Twitter
{
    static void Main()
    {
        // Write your code here
        string tweet;

        Console.WriteLine("Enter a message to upload to Twitter: ");
        Console.WriteLine("Messages are limited to 140 characters.");
        Console.WriteLine();
        tweet = Console.ReadLine();

        if (tweet.Length >= 140 )
        {
            Console.WriteLine();
            Console.WriteLine("The message is too long.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The message is okay.");
        }
    }
}
