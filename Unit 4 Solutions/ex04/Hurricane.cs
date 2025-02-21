using System;
using static System.Console;
using System.Globalization;
class Hurricane
{
    static void Main()
    {
        // Write your code here
        int category;
        int speed;

        Console.WriteLine("Enter the wind speed: ");
        speed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        if (speed >= 74 && speed < 96 )
        {
            category = 1;
            Console.WriteLine("Wind speed registered at {0}, this is a category {1} hurricane! Be cautious of dangers and listen for safety precautions and begin making a plan.", speed, category);
        }
        else if (speed >= 96 && speed < 111)
        {
            category = 2;
            Console.WriteLine("Wind speed registered at {0}, this is a category {1} hurricane! Threat levels are rising, be adviced of the best safety measures and follow your safety plan.", speed, category);
        }
        else if (speed >= 111 && speed < 130)
        {
            category = 3;
            Console.WriteLine("Wind speed registered at {0}, this is a category {1} hurricane! High risk of danger, begin seeking shelter as soon as possible.", speed, category);
        }
        else if (speed >= 130 && speed < 157)
        {
            category = 4;
            Console.WriteLine("Wind speed registered at {0}, this is a category {1} hurricane! Danger and destruction imminent, seek shelter and barricade yourself RIGHT NOW!", speed, category);
        }
        else if (speed >= 157)
        {
            category = 5;
            Console.WriteLine("Wind speed registered at {0}, this is a category {1} hurricane! Good luck!", speed, category);
        }
        else
        {
            Console.WriteLine("Wind speeds recorded under 74 mph are not hurricanes, kites can be fun to use today!");
        }
    }
}