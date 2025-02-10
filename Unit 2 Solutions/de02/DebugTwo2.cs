// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
class DebugTwo2
{
    static void main()
    {
        string name;
        string firstString; 
        string secondString;
        int first;
        int second; 
        int product;
        Console.WriteLine("Enter your name >> ");
  
        name = Console.ReadLine();
        Write("Hello, {0}! Enter an integer >> ", name);
        firstString = Console.ReadLine();
        first = Convert.ToInt32(firstString);
        Write("Enter another integer >> ");
        secondString = Console.ReadLine();
        second = Convert.ToInt32(secondString);
        product = first * second;
        WriteLine("Thank you, {1}. The product of {2} and {3} is {4}",
       name, first, second, product);
    }
}
