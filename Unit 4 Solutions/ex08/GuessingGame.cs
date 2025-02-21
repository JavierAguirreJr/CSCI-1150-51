using System;
using static System.Console;
using System.Globalization;
class GuessingGame
{
    static void Main()
    {
        // Write your code here
        Random rnd = new Random();
        int randomNumber;
        //int min = 1;
        //int max = 11;
        int userGuess;
        randomNumber = rnd.Next(1, 11);

        Console.WriteLine("Welcome to Guessing Game");
        Console.WriteLine("Guess a number between 1 and 10");
        userGuess = Convert.ToInt32(Console.ReadLine());

        if (randomNumber > userGuess)
        {
            Console.WriteLine("{0}, that guess was too low, sorry!", userGuess);
            Console.WriteLine("The correct number was {0}!", randomNumber);
        }
        else if (randomNumber < userGuess)
        {
            Console.WriteLine("{0}, that guess was too high, sorry!", userGuess);
            Console.WriteLine("The correct number was {0}!", randomNumber);
        }
        else
        {
            Console.WriteLine("{0} is correct! You win!", userGuess);
        }
    }
}