/************************************************************************************
 * Name        : Hussein Mahmoud
 * Description : C# assignment05 [enum]
 * Date        : 16 July 2025
 ************************************************************************************/



using System.Transactions;

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

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }


        static void Main(string[] args)
        {

            #region Q1
            /* 1- Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that
                 * prints out all the days of the week using this enum. */

            //Weekday weekday = Weekday.Monday;
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine((Weekday)((int)weekday << i)); //cast to int to perform shifting operation then cast to Weekday to display in enum format
            //} 
            #endregion

            /*2. Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program
             * that takes a season name as input from the user and displays the corresponding month range for that season. Note range for 
             * seasons ( spring march to may , summer june to august , autumn September to November , winter December to February) */
            Season season;
            object obj01;
     

            do
            {
                Console.Write("Enter a season name: ");
            }
            while (!Enum.TryParse(typeof(Season), Console.ReadLine(), true, out obj01));


            
                season = (Season)obj01;

                if (season == Season.Spring)
                {
                    Console.WriteLine("Spring range: March to May");
                }

                else if (season == Season.Summer)
                {
                    Console.WriteLine("Summer range: June to August");
                }

                else if (season == Season.Autumn)
                {
                    Console.WriteLine("Autumn range: September to November");
                }

                else
                {
                    Console.WriteLine("Winter range: December to February");
                }
           



        }
            
        }
    }

