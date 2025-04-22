using System;
using static System.Console;
using System.Globalization;
class SwimmingWaterTemperature
{
    static void Main()
    {
        // Write your code here
        int temp;

        try
        {
            Console.WriteLine("What is the current water temperature?");
            temp = Convert.ToInt32(Console.ReadLine());
            WaterCheck(temp);

        }
        catch (ArgumentException ex) 
        {
            Console.WriteLine("{0}", ex.Message);
        }
        Console.WriteLine("{0} degrees is comfortable for swimming");
    }
    static int WaterCheck(int h20)
    {
        if (h20 < 32 || h20 > 212)
        {
            throw new ArgumentException(String.Format("{0} degress is not comfortable for swimming", h20), "h20");
        }
        else
        {
            return h20;
        }
    }
}

/*
 `ArgumentException` is an existing class that derives from `Exception`; you use it when one or more of a method’s arguments do not fall within an expected range. 

Write the application `SwimmingWaterTemperature` containing a variable that can hold a temperature expressed in degrees Fahrenheit. 
Within the class, create a method that accepts a parameter for a water temperature and returns true or false, indicating whether the water 
temperature is between **70** and **85** degrees and thus comfortable for swimming. If the temperature is not between **32** and **212** 
(the freezing and boiling points of water), it is invalid, and the method should throw an `ArgumentException`. 

In the `Main()` method, continuously prompt the user for data temperature, pass it to the method, and then display the following messages 
indicating whether the temperature is comfortable, not comfortable, or invalid:
```
X degrees is comfortable for swimming.
X degrees is not comfortable for swimming.
Value does not fall within the expected range.
```

Enter the value **999** to quit the program. 

 */