using System.Security.AccessControl;

namespace Demo05
{
    internal class Program
    {
        enum Season : byte
        {
            Spring,
            Winter = 10,
            Summer,
            Autumn
        }
        enum Weekday
        {
            Saturnday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Friday
        }
        enum Gender
        {
            Male = 1,
            Female = 2,
            M = 1,
            F = 2
        }

        //Read, Write, Execute, Delete
        [Flags]
        enum Permissions
        {
            Read = 8,
            Write = 4,
            Execute = 2,
            Delete = 1
        }

        static void DoSomeCode()
        {
            try
            {
                int num1, num2, num3;
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                num3 = int.Parse(Console.ReadLine());

                num3 = num1 / num2;

                int[] arr = { 1, 2, 3 };

                arr[99] = 10;

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally 
            {
                //release - deallocate - Disconnect - Dispose unmanaged resource
                Console.WriteLine("Finally");
            }
        }

        static void DoSomeProtectiveCode()
        {
            try
            {
                int num1, num2, num3;

                do
                {
                    Console.Write("Enter the value of integer num1: ");
                }
                while (!int.TryParse(Console.ReadLine(), out num1));

                do
                {
                    Console.Write("Enter the value of integer num2: ");
                }
                while (!(int.TryParse(Console.ReadLine(), out num2)) || num2 == 0);

                num3 = num1 / num2;

                int[] arr = { 1, 2, 3 };

                if (99 < arr?.Length)
                {
                    arr[99] = 10;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {

            #region Casting [Boxing and Unboxing]
            #region Boxing [Safe Casting]
            //We want to avoid boxing and unboxing processes for better performance
            //int num1 = 100;
            //object obj = num1; //Boxing
            //                   //Implicitly [Safe casting]
            //                   //Take compy from value and wraping the value in an object

            //obj = 12.3;  //Casting from value type [double] => reference type [Object]
            //obj = 'A';   //Casting from value type [char] => reference type [Object]
            //obj = 12.3f; //Casting from value type [float] => reference type [Object]
            //obj = true;  //Casting from value type [bool] => reference type [Object]
            //obj = new DateTime(); //Casting from value type [datetime] => reference type [Object]

            //Console.WriteLine(obj);

            #endregion

            #region Unboxing [Unsafe casting]
            //object obj1 = "Hussein";
            //int x = (int)obj1; //Invalid : runtime error : : 'Unable to cast object of type 'System.String' to type 'System.Int32'.'
            #endregion

            #endregion

            #region Nullable Value Type Ex01
            //int num1 = 10;
            //num1 = null; //invalid

            //Nullable<int> num2 = 20;
            //Console.WriteLine($"num2 = {num2}"); //num2 = 20

            //num2 = null;
            //Console.WriteLine($"num2 = {num2}"); //num2 = 

            //int? num3 = 30;
            //Console.WriteLine($"num3 = {num3}"); //num3 = 30

            //num3 = null;
            //Console.WriteLine($"num3 = {num3}"); //num3 =  
            #endregion

            #region Nullable Value Type Ex02
            //int num1 = 10;
            //int? num2 = num1; //Valid: Implicitly Casting
            //                  //num1 can hold int values only
            //                  //num2 can hold int values and null

            //num1 = (int)num2; //must use explicit casting here! [Unsafe]

            //Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            #endregion

            #region Nullable Value Type Ex03
            //int? num1 = 10;
            //int num2;

            ////this example is a safe code unlike ex03
            //if (num1 is not null)
            //{
            //    num2 = (int)num1;
            //}

            //else
            //{
            //    num2 = 0;
            //}

            //Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            #endregion

            #region Nullable Value Type Ex04
            //int? num1 = null;
            //int num2;

            //this example is a safe code unlike ex02
            //if (num1.HasValue)
            //{
            //    num2 = num1.Value;
            //}

            //else
            //{
            //    num2 = 0;
            //}

            ////or
            //num2 = (num1.HasValue) ? num1.Value : 0;

            ////or
            ///Using Null coalescing operator
            //num2 = num1 ?? 0;

            //Console.WriteLine($"num1 = {num1}, num2 = {num2}");
            #endregion

            #region Nullable Value Type Ex05
            //int? num1 = null;
            ////int num2 = num1.HasValue ? num1.Value : 0;
            ////int num2 = num1 ?? 0; // Noncoalesce operator
            //int num2 = num1.GetValueOrDefault(); // Noncoalesce operator
            //Console.WriteLine($"num1 = {num1}, num2 = {num2}");

            #endregion

            #region Nullable Reference Type
            ////#nullable enable
            ////#nullable disable
            //string name01 = null!; // "!" is a null-forgiving operator that disable such warning
            //Console.WriteLine(name01);

            //string? name02 = null;
            //Console.WriteLine(name02);
            #endregion

            #region Null Propagation Operator ?
            //double num1 = default; //0
            //Console.WriteLine(num1);

            //char C = default;
            //Console.WriteLine(C); //

            //bool b = default;
            //Console.WriteLine(b); //false

            //int[] arr = default; //null

            //if(arr is not null)
            //    for (int i = 0; (i < arr.Length); i++) 
            //        Console.WriteLine(arr[i]);

            ////Or using null Propagation Operator ?
            //for (int i = 0; (i < arr?.Length); i++)
            //    Console.WriteLine(arr[i]);

            //int Len = arr is not null ? arr.Length : -1;
            ////or
            //Len = arr?.Length ?? -2;
            //Console.WriteLine(Len); //-2
            #endregion

            #region Exception Handling
            //DoSomeCode();
            //DoSomeProtectiveCode();
            #endregion

            #region Access Modifiers
            ////Common.TypeA typeA = new Common.TypeA();  //Invalid if typeA is internal and its not in same project
            //Common.TypeB typeB = new Common.TypeB(); //Valid

            ////typeB.num1 = 1; //Invalid because num1 member is private
            ////typeB.num2 = 2; //Invalid because num1 member is internal and not in same project
            //typeB.num3 = 3; //valid because its public

            #endregion

            #region Enum Part01
            //user defined datatype stored in stack
            //Season season;
            //season = Season.Winter;
            //Console.WriteLine(season); //Winter
            //Console.WriteLine((int)season); //10

            //Gender gender01 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine(), true); //third parameter ignor case sensitive
            //Console.WriteLine(gender01);

            //Gender gender02;
            //if(Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object obj01))
            //{
            //    gender02 = (Gender)obj01;

            //    Console.WriteLine(gender02);
            //}
            #endregion

            #region Part02
            Permissions permission01 = Permissions.Read;
            permission01 ^= Permissions.Delete; //Toggle permission
            Console.WriteLine(permission01); //Delete, Read
            Console.WriteLine((int)permission01); //9

            permission01 |= Permissions.Execute; //Add permission
            Console.WriteLine(permission01); //Delete, Execute, Read

            permission01 &= ~(Permissions.Read); //Remove permission 
            Console.WriteLine(permission01); //Delete, Execute

            if ((permission01&Permissions.Read) == (Permissions.Read)) //false
            {
                Console.WriteLine("Read permission Exists");
            }

            else
            {
                Console.WriteLine("Read permission doesn't Exist");
            }

            #endregion

        }
    }
}
