using System;

namespace MyStuff_Dates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime rightNow = DateTime.Now;
            DateTime anHourLater = rightNow.AddHours(1);

            //Can we get this to just return the date part, not the empty time stamp part
            DateTime justDate = DateTime.Today;
            bool dstSetting = rightNow.IsDaylightSavingTime();

            Console.WriteLine("The contents of rightNow is :" + rightNow);
            Console.WriteLine("The time one hour later is :" + anHourLater);
            Console.WriteLine("Just the date is :" + justDate);
            Console.WriteLine("And the time is :" + rightNow.TimeOfDay);
            Console.WriteLine("And the DST setting is :" + dstSetting);

            //Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();


        }
    }
}
