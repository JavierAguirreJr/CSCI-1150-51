using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
    static void Main()
    {
        // Write your code here
        //int lastYear;
        int thisYear;
        int entryFee = 25;
        string[] talent = { "S", "D", "M", "O" };
        string[] talentFull = { "Singing", "Dancing", "Musical Instrument", "Other" };
        int[] talentTotal = { 0, 0, 0, 0 };
        bool goodTalent = false;
        const string quit = "q";
        string talentChoice;

        Console.WriteLine();
        Console.WriteLine("Enter the number of contestants this year: ");
        thisYear = int.Parse(Console.ReadLine());
        //do
        //{
        //    Console.WriteLine("Please enter a valid entry for number of contestants this year.");
        //    Console.WriteLine("Valid entry values are between 0 and 30.");
        //    Console.WriteLine();
        //    Console.WriteLine("Enter the number of contestants this year: ");
        //    thisYear = int.Parse(Console.ReadLine());
        //}
        //while (thisYear > 30);

        Console.WriteLine();
        Console.WriteLine("Select the number of contestans for a category you are looking to update.");
        Console.WriteLine("S for Singing, D for Dancing, M for Musical Instrument or O for Other");

        talentChoice = Console.ReadLine().ToUpper();
        Console.WriteLine();
        int index = Array.BinarySearch(talent, talentChoice);
        
        for (int x = 0; x < talentTotal.Length; x++)
        {
            if (index.ToString() == talent[x])
            {
                Console.WriteLine("Enter the number of contestants that signed up as {0}", talentFull[x]);
                talentTotal[x] += Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Please make a proper selection based on the shown categories.");
                talentChoice = Console.ReadLine();
            }
        }
       
        //        //Console.WriteLine("Enter another interger to be included to your previous total or press " + quit + " (zero) to quit.");
        //        //= Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The types of talent are:");
        Console.WriteLine(talentFull[0] +":     " + talentTotal[0]);
        Console.Read();
        /*
        Now, modify your version of the *GreenvilleRevenue* program created in *Chapter 5* so that after the user enters the number of 
        contestants in this year’s competition, the user is prompted for the appropriate number of contestant names and a code for each 
        contestant that indicates the type of talent: 
        * S for singing
        * D for dancing
        * M for playing a musical instrument
        * O for other. 

        Make sure that all entered codes are valid, and if not, re-prompt the user to enter a correct code.  For example, if **Y** is input, 
        output **Y is not a valid code**, and re-prompt the user until a valid code is entered.

        After contestant data entry is complete, display a count of each type of talent.  For example, if there were ten singers, four dancers, 
        seven people who play musical instruments, and one in the other category, the output should be:
        ```
        The types of talent are:
        Singing              10
        Dancing               4
        Musical instrument    7
        Other                 1
        ```

        Then, continuously prompt the user for a talent code until the user enters a sentinel value (the uppercase character **Z** should be used 
        as the sentinel value). 

        With each code entry, display a list of the contestants with that code, or display a message that the code is not valid and re-prompt the user.  
        For example, if **M** is entered, the output might be:
        ```
        Contestants with talent Musical instrument are:
        Michelle
        Nick
        ```
        If **U** is entered, the output should be **U is not a valid code**.
         */

        /*
         WriteLine("Enter the number of contestants last year: ");
        lastYear = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Please enter a valid entry for number of contestants last year.");
            Console.WriteLine("Valid entry values are between 0 and 30.");
            Console.WriteLine();
            Console.WriteLine("Enter the number of contestants last year: ");
            lastYear = int.Parse(Console.ReadLine());
        }
        while (lastYear < 0 || lastYear > 30);

        Console.WriteLine();
        Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants.", lastYear, thisYear);
        Console.WriteLine("Revenue expected this year is {0}", (thisYear * entryFee).ToString("C", CultureInfo.GetCultureInfo("en-US")));

        if (lastYear * 2 < thisYear)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (lastYear < thisYear)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
        */
    }
}
