using System;

namespace DateDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your birthday in the format MM/DD/YYYY");
            string input1 = Console.ReadLine();
            input1 = FormatTest(input1);
            Console.WriteLine("Please enter today's date in the format MM/DD/YYYY");
            string input2 = Console.ReadLine();
            input2 = FormatTest(input2);
            DateTime date1 = (Convert.ToDateTime(input1));
            DateTime date2 = (Convert.ToDateTime(input2));
            TimeSpan lifeSpan = date2.Subtract(date1);
            //lifespan spits out how many days are between the dates
            double inDays = lifeSpan.Days;
            double inHours = (inDays * 24);
            double inMins = (inHours * 60);
            Console.WriteLine("");
            Console.WriteLine("Woah," +
                              "\nYou have been alive for " + inDays + " Days!" +
                              "\nThat's " + inHours + " hours!" +
                              "\nOr " + inMins + " minutes!");
            Console.ReadLine();
        }
        static string FormatTest(string input)
        {
            bool tryAgain = true;
            while (tryAgain == true)
            {
                if (DateTime.TryParse(input, out DateTime temp))
                {
                    //Console.WriteLine("Thank You.");
                    tryAgain = false;
                }
                else
                {
                    Console.WriteLine("Your date is not in the correct format, please re-enter");
                    input = Console.ReadLine();
                    tryAgain = true;
                }
            }
            return input;
        }
    }
}