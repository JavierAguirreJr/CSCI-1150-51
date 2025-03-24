using System;
using static System.Console;
using System.Globalization;
class PaintingEstimate
{
    static void Main()
    {
        // Write your code here
        int length;
        int width;
        int roomTotal;
        int priceTotal;

        Console.WriteLine("Enter the length of the room in feet: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Enter the width of the room in feet: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        roomTotal = Calculation(length, width);
        priceTotal = roomTotal * 6;
        Console.WriteLine("The cost of the job for {0} x {1} foot room is {2}", length, width, priceTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
    private static int Calculation (int length, int width)
    {
        int perimeter = (length * 2) + (width * 2);
        int total = perimeter * 9;
        return total;
    }
}