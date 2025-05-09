using System;
using static System.Console;
using System.IO;
class DirectoryInformation
{
    static void Main()
    {
        const string END = "END";
        string search;
        string[] dir;

        Write("Enter a directory >> ");
        search = ReadLine();
        while (search != END)
        {
            if (Directory.Exists(search))
            {
                dir = Directory.GetFileSystemEntries(search);
                Console.WriteLine(search + " contains the following files: ");
                Console.WriteLine();
                for (int x = 0; x <= dir.Length; ++x)
                {
                    Console.WriteLine("  " + dir[x]);
                }
                Write("Enter next student number or " + END + " to quit ");
            }
            else
            {
                Console.WriteLine("Directory {0} does not exist", search);
                Console.ReadKey();
            }
        }
    }
}

/*
Write the program named `DirectoryInformation`  that allows a user to continually enter directory 
names until the user types **end**. If the directory name exists, display a list of the files in it; otherwise, display the following message, 
`Directory foo does not exist`, to indicate the directory does not exist  (`foo` would be the name of the directory to be checked) . 
Create as many test directories and files as necessary to test your program.

An example of the program is shown below: 
```
Enter a directory >> lorem
lorem contains the following files
  lorem/ipsum.txt

Enter another directory or type end to quit >> foo
Directory foo does not exist
```
 */