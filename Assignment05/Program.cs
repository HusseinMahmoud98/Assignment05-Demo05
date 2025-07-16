/************************************************************************************
 * Name        : Hussein Mahmoud
 * Description : C# assignment05 [enum]
 * Date        : 16 July 2025
 ************************************************************************************/



namespace Assignment05
{
    internal class Program
    {
        [Flags]
        enum Weekday
        {
            Monday = 2,
            Tuesday = 4,
            Wednesday = 8,
            Thursday = 16,
            Friday = 32,
            Saturnday = 64,
            Sunday = 128,
        }


        static void Main(string[] args)
        {

            #region MyRegion
            /* 1- Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that
                 * prints out all the days of the week using this enum. */

            Weekday weekday = Weekday.Monday;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((Weekday)((int)weekday << i)); //cast to int to perform shifting operation then cast to Weekday to display in enum format
            } 
            #endregion

        }
    }
}
