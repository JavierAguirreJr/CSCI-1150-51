// Program asks user to enter a stock number
// If the stock number is not 209, 312, or 414 the user must reenter the number
// The program displays the correct price
using System;
using static System.Console;
using System.Globalization;
class DebugFive2
{
    static void Main()
    {
        const string ITEM209 = "209";
        const string ITEM312 = "312";
        const string ITEM414 = "414";
        const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
        double price;
        string stockNum;

        Write("Please enter the stock number of the item you want: ");
        stockNum = ReadLine();

        while (stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414)
        {
            WriteLine();
            WriteLine("Invalid stock number. Please enter again. ");
            stockNum = Console.ReadLine();
        }
        if (stockNum == ITEM209)
            price = PRICE209;
        else if (stockNum == ITEM312)
            price = PRICE414;
        else
            price = PRICE312;
        WriteLine();
        WriteLine("The price for item # {0} is {1}", stockNum, price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}
