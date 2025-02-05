using System;
using static System.Console;
using System.Globalization;
class EggsInteractive
{
    static void Main()
    {
        // Write your code here
        int chicken1;
        int chicken2;
        int chicken3;
        int chicken4;

        Console.WriteLine("How many eggs did your first chicken lay?");
        chicken1 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("How many eggs did your second chicken lay?");
        chicken2 = int.Parse(Console.ReadLine());
        Console.WriteLine(); 
        Console.WriteLine("How many eggs did your third chicken lay?");
        chicken3 = int.Parse(Console.ReadLine());
        Console.WriteLine(); 
        Console.WriteLine("How many eggs did your fourth chicken lay?");
        chicken4 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;

        int dozenEggs = totalEggs / 12;
        int eggs = totalEggs % 12;



        Console.WriteLine("**{0} eggs is {1} dozen and {2} eggs**", totalEggs, dozenEggs, eggs);
    }
}