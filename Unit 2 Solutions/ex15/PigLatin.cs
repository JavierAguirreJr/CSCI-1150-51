using System;
using static System.Console;
using System.Globalization;
class PigLatin
{
    static void Main()
    {
        // Write your code here
        string word;
        string ay = "ay";
        string pigLatin;

        Console.WriteLine("Enter a word to convert to Pig Latin: ");
        word = Console.ReadLine();

        pigLatin = word.Substring(0,1); //dog - d
        word = word.Substring(1); //dog - og
        pigLatin = pigLatin + ay; //day
        pigLatin = word + pigLatin; //ogogay
        Console.WriteLine();
        Console.WriteLine("Your Pig Latin word is: " + pigLatin);
        Console.Read();
    }
}