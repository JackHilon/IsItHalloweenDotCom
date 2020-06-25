using System;

namespace IsItHalloweenDotCom
{
    class Program
    {
        static void Main(string[] args)
        {
            // IsItHalloween.com 
            // https://open.kattis.com/problems/isithalloween 
            // just simple compare

            Console.WriteLine(MyCheck(EnterLine()));
        }
        private static string MyCheck(object[] date)
        {
            // October 31 or December 25 --> output yup
            string month = (string)date[0];
            int day = (int)date[1];
            if (month == "OCT" && day == 31)
                return "yup";
            else if (month == "DEC" && day == 25)
                return "yup";
            else
                return "nope";
        }

        private static object[] EnterLine()
        {
            var arr = new string[2] { "", "" };
            object[] res = new object[2] { "", 0 };

            try
            {
                arr = Console.ReadLine().Split(' ', 2);
                res[0] = arr[0].ToUpper();
                res[1] = int.Parse(arr[1]);
                if (Conditions(res) == false)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterLine();
            }
            return res;
        }

        private static bool Conditions(object[] array)
        {
            // JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC
            string month = (string)array[0];
            int day = (int)array[1];
            if (month != "JAN" && month != "FEB" && month != "MAR" && month != "APR" && month != "MAY"
                && month != "JUN" && month != "JUL" && month != "AUG" && month != "SEP" && month != "OCT"
                && month != "NOV" && month != "DEC")
                return false;
            else if (day < 0 || day > 31)
                return false;
            else 
                return true;
        }
    }
}
