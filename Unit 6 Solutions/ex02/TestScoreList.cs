using System;
using static System.Console;
using System.Globalization;
class TestScoreList
{
    static void Main()
    {
        // Write your code here
        const int testAvg = 83;
        int testScore;
        int[] testList = new int[8];

        //Console.WriteLine("Enter a test score to be added to the list");
        //testScore = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < testList.Length; i++)
        {
            Console.WriteLine("Enter another test score to be added to the list");
            testScore = Convert.ToInt32(Console.ReadLine());
            testList[i] = testScore;
            Console.WriteLine();
            //i++;
        }
        int counter = 0;
        foreach (int i in testList)
        {
            Console.WriteLine("Test #{0}:    {1}. From average:    {2}", counter, i, i - testAvg);
            counter++;
        }
        Console.ReadKey();
    }
}
