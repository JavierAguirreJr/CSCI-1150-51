using System;
using static System.Console;
using System.Globalization;
class SalesLetter
{
    static void Main()
    {
        // Write your code here
        Console.WriteLine("Enter the clients name: ");
        string clientName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Enter a message to send to the client: ");
        string clientMessage = Console.ReadLine();
        Console.WriteLine();
        string signature = "Looking forward to a long relationship.";

        Console.Clear();

        Console.WriteLine("From:");
        DisplayContactInfo(); //Info
        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();
        Console.WriteLine("Dear {0},", clientName);
        Console.WriteLine(clientMessage);
        DisplayContactInfo(); //Info
        Console.WriteLine("   ******************          ");
        Console.WriteLine();
        Console.WriteLine(signature);
        DisplayContactInfo(); //Info
    }
    private static void DisplayContactInfo()
    {
        Console.WriteLine("C# Company");
        Console.WriteLine("Phone: 555-1234      Cell: 555-0912");
        Console.WriteLine("Email: csharpcompany@csharp.com");
        Console.WriteLine("On the Web at www.csharpcompanyforyou.com");
    }
}