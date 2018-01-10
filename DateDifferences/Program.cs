using System;

namespace DateDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthday in the format MM/DD/YYYY");
            DateTime input1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Please enter today's date in the format MM/DD/YYYY");
            DateTime input2 = Convert.ToDateTime(Console.ReadLine());
            TimeSpan lifeSpan = input2.Subtract(input1);
            //lifespan spits out how many days are between the dates
            double inDays = lifeSpan.Days;
            double inHours = (inDays * 24);
            double inMins = (inHours * 60);
            Console.WriteLine("Woah," +
                              "\nYou have been alive for " + inDays + " Days!" +
                              "\nThats " + inHours + " hours!" +
                              "\nOr " + inMins + " minutes!");
            Console.ReadLine();
        }
    }
}
