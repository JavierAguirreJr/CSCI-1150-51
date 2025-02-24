// Program asks user to enter password
// If password is not "home", "lady" or "mouse"
// the user must re-enter the password
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
class DebugFive1
{
    static void Main()
    {
        const string PASS1 = "home";
        const string PASS2 = "lady";
        const string PASS3 = "mouse";
        string password;

        Write("Please enter your password: ");
        Console.WriteLine();
        password = Console.ReadLine();

        while (password != PASS1 && password != PASS2 && password != PASS3)
        {
            WriteLine("Invalid password. Please enter again. ");
            password = ReadLine();
        }      

        //password = ReadLine();
        WriteLine("Valid password");
    }
}
