using System;
using static System.Console;
using System.Globalization;
using System.ComponentModel.Design;
class Lyrics
{
    static void Main()
    {
        // Write your code here
        Console.WriteLine("Select the number to one of the following bands to read some of their lyrics:");
        Console.WriteLine("1 - Slayer");
        Console.WriteLine("2 - Led Zeppelin");
        Console.WriteLine("3 - Bloc Party");
        Console.WriteLine();
        int bandChoice = Convert.ToInt32(Console.ReadLine());

        switch (bandChoice)
        {
            case 1:
                Console.WriteLine();
                Console.WriteLine("Slayer - One of Thrash Metals original and most well known bands. Here are a few lines from their most popular songs:");
                Console.WriteLine();
                Console.WriteLine("Raining Blood: 'Trapped in purgatory, a lifeless object alive...Raining Blood from a lacerated sky.");
                Console.WriteLine();
                Console.WriteLine("Hell Awaits: Angels fighting aimlessly, Still dying by the sword..Your souls are damned...Hell awaits.");
                Console.WriteLine();
                Console.WriteLine("World Painted Blood: Slaughter governs law, the apocalypse beings...God is laughing hard, man has gone insane, World painted blood, no sanctuary.");
                Console.ReadKey();
                break;
            case 2:
                Console.WriteLine();
                Console.WriteLine("Led Zeppelin - Arguably one of the greatest rock bands to ever exist. Let the Led out with these great verses:");
                Console.WriteLine();
                Console.WriteLine("Achilles Last Stand: Oh, the fun to have to live the dreams we always had...If one bell should in celebration for the king.");
                Console.WriteLine();
                Console.WriteLine("The Rain Song: It is the springtime of my loving...It is the summer of my smiles, flee from me, keepers of the gloom.");
                Console.WriteLine();
                Console.WriteLine("Going to California: Going to California with an aching in my heart, someone told me there's a girl out there " +
                    "with love in her eyes and flowers in her hair");
                Console.ReadKey();
                break;
            case 3:
                Console.WriteLine();
                Console.WriteLine("Bloc Party - One of the 2000's indie-alternative rock scenes most unique and most underrated band, enjoy the British vibes:");
                Console.WriteLine();
                Console.WriteLine("Blue Light: You didn't even notice when the sky turned blue, and you couldn't tell the difference between me and you and I nearly didn't notice" +
                    "the gentlest feeling, you are the bluest light");
                Console.WriteLine();
                Console.WriteLine("The Pioneers: If it can be broke, then it can be fixed, if it can be lost, then it can be won. We will not be the first. " +
                    "We said we're going to conquer new frontiers, so here we are reinventing the wheel, we will not be the last.");
                Console.WriteLine();
                Console.WriteLine("This Modern Love: Don't get offended if I seem absent minded, Just keep telling me facts and keep making me smile, I get tongue-tied.");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Please select an option between 1, 2 and 3");
                break;
        }
    }
}