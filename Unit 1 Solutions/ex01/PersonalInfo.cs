using System;
using static System.Console;
using System.Globalization;
class PersonalInfo
{
    static void Main()
    {
        // Write your code here
        /* Example:
            ```
            Lucinda Potter
            6/24/1992
            work 000-555-0101
            cell 000-555-0189
            ```
         */

        string personName;
        string personDOB;
        string monthDOB;
        string dayDOB;
        string yearDOB;
        string workPhoneArea;
        string workPhone;
        string cellPhoneArea;
        string cellPhone;


        Console.WriteLine("Enter your name");
        personName = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("What month were you born in (MM)?");
        monthDOB = Console.ReadLine();
        Console.WriteLine("What day of the month (DD)?");
        dayDOB = Console.ReadLine();
        Console.WriteLine("What year were you born (YYYY)?");
        yearDOB = Console.ReadLine();
        Console.Clear();

        personDOB = monthDOB + "/" + dayDOB + "/" + yearDOB;

        Console.WriteLine("Enter your work phone area code");
        workPhoneArea = Console.ReadLine();
        Console.WriteLine("Enter your work phone number");
        workPhone = Console.ReadLine();

        workPhone = workPhoneArea + "-" + workPhone.Substring(0, 3) + "-" + workPhone.Substring(workPhone.Length - 4);
        Console.Clear();

        Console.WriteLine("Enter your cell phone area code");
        cellPhoneArea = Console.ReadLine();
        Console.WriteLine("Enter your work phone number");
        cellPhone = Console.ReadLine();

        cellPhone = cellPhoneArea + "-" + cellPhone.Substring(0, 3) + "-" + cellPhone.Substring(cellPhone.Length - 4);
        Console.Clear();

        Console.WriteLine("The following personal information was entered:");
        Console.WriteLine(personName);
        Console.WriteLine(personDOB);
        Console.WriteLine(workPhone);
        Console.WriteLine(cellPhone);
        Console.Read();
    }
}
