//Given an integer N as input, which represents the number of electricity units consumed.
//Calculate the total electricity bill according to the given conditions:

//For first 50 units $ 0.50/unit
//For next 100 units $ 0.75/unit
//For next 100 units $ 1.20/unit
//For unit above 250 $ 1.50/unit
//An additional surcharge of 20% is added to the bill.



//Input:

//    150    

//    where:

//Input represents the value of integer N.
//Output:

//    120.000000


using System;
namespace Asst1
{
    public class Program2
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var i = 0;
            var sum = 0.0;
            while (N > 0) {
                if (i == 0) {
                    if (N >= 50) {
                        sum = sum + (50 * 0.5);
                        N -= 50;
                    }
                    else
                    {
                        sum = sum + (N * 0.5);
                        N = 0;
                    }
                    i += 1;
                }
                else if (i == 1)
                {
                    if (N >= 100)
                    {
                        sum = sum + (100 * 0.75);
                        N -= 100;
                    }
                    else
                    {
                        sum = sum + (N * 0.75);
                        N = 0;
                    }
                    i += 1;
                }
                else if (i == 2)
                {
                    if (N >= 100)
                    {
                        sum = sum + (100 * 1.20);
                        N -= 100;
                    }
                    else
                    {
                        sum = sum + (N * 1.20);
                        N = 0;
                    }
                    i += 1;
                }
                else if (i == 3) {
                    sum = sum + (N * 1.50);
                    N = 0;
                    i += 1;
                }
            }
            sum = sum + sum * 0.2;
            Console.WriteLine(sum);
        }
    }
}
