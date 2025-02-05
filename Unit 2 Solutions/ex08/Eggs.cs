using System;
using static System.Console;
using System.Globalization;
class Eggs
{
    static void Main()
    {
        // Write your code here
        int chicken1 = 34;
        int chicken2 = 33;
        int chicken3 = 31;
        int chicken4 = 29;
        int totalEggs = chicken1 + chicken2 + chicken3 + chicken4;
        int dozenEggs = totalEggs / 12;
        int eggs = totalEggs % 12;

        Console.WriteLine("**{0} eggs is {1} dozen and {2} eggs**", totalEggs, dozenEggs, eggs);
    }
}