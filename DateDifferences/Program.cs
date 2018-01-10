using System;

namespace DateDifferences
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Please enter your birthday in the format MM/DD/YYYY");
        //    DateTime input1 = Convert.ToDateTime(Console.ReadLine());
        //    Console.WriteLine("Please enter today's date in the format MM/DD/YYYY");
        //    DateTime input2 = Convert.ToDateTime(Console.ReadLine());
        //    TimeSpan lifeSpan = input2.Subtract(input1);
        //    //lifespan spits out how many days are between the dates
        //    double inDays = lifeSpan.Days;
        //    double inHours = (inDays * 24);
        //    double inMins = (inHours * 60);
        //    Console.WriteLine("Woah," +
        //                      "\nYou have been alive for " + inDays + " Days!" +
        //                      "\nThat's " + inHours + " hours!" +
        //                      "\nOr " + inMins + " minutes!");
        //    Console.ReadLine();
        //}
        //static void FormatCheck(DateTime input1)
        //{
        //    bool tryAgain = true;
        //    while(tryAgain == true)
        //    {
        //        DateTime temp;
        //        if (DateTime.TryParse(input1, out temp))
        //        {
        //            Console.WriteLine("Thank You.");
        //            tryAgain = false;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Your date is not in the correct format, please re-enter");
        //            input1 = Convert.ToDateTime(Console.ReadLine());
        //            tryAgain = true;
        //        }
                

        //    }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthday in the format MM/DD/YYYY");
            DateTime input1 = Format();
        }
        static DateTime Format(Console.ReadLine())
        {

        }

    }
}
