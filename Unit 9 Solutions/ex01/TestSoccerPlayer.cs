using System;
using static System.Console;
using System.Globalization;
class TestSoccerPlayer
{
    static void Main()
    {
        // Write your code here
        SoccerPlayer player = new SoccerPlayer();
        player.Name= "Test";
        player.JerseyNum = 51;
        player.Goals = 4;
        player.Assist = 5;
    }
}
class SoccerPlayer
{
    public string Name { get; set; }
    public int JerseyNum { get; set; }
    public int Goals { get; set; }
    public int Assist {  get; set; }
}

/*
 Create an application named *TestSoccerPlayer* that instantiates and displays a
`SoccerPlayer` object. The `SoccerPlayer` `class` contains the following properties:

* `Name` - The player’s name ( a string)
* `JerseyNum` - The player's jersey number (an integer)
* `Goals` - Number of goals scored (an integer)
* `Assists` - Number of assists (an integer)

 */