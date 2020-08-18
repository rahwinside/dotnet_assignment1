//Find number of days in the month
//Given an integer N as an input, where N indicates the number of the month in a Gregorian year.
//e.g. 1 represents "January", 2 represents "February" and vice versa.
//Month numbers 1, 3, 5, 7, 8, 10 and 12 represent Jan, Mar, May, Jul, Aug, Oct, and Dec.These months have 31 days, so display 31 for them.
//Month numbers 4, 6, 9 and 11 represent Apr, Jun, Sep, and Nov.These months have 30 days, so display 30 for them.
//Month number 2 represents Feb, which has 27 or 28 days, so regardless of the leap years display 27 for Feb.

//Input:

//    1
//    where:

//Input is a month number.


//Output:

//    31 

//Explanation: As 1 represents the month of January and it has 31 days, so the output is "31".

//Assumption:

//Month number can be in the range 1 to 12.

using System;
namespace Asst1
{
    public class Program4
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            switch (n) {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30");
                    break;
                case 2:
                    Console.WriteLine("28");
                    break;
            }
        }
    }
}
