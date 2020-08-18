//Determine weather conditions based on temperature

//Given an integer as an input, it represents the temperature in centigrade.Determine the weather conditions based on the temperature.

//Temperature< 0 then print "Freezing weather".
//Temperature 0 - 10 then print "Very cold weather".
//Temperature 10 - 20 then print "Cold weather".
//Temperature 20 - 30 then print "Normal in temperature".
//Temperature 30 - 40 then print "Its Hot".
//Temperature >= 40 then print "Its Very Hot".

//Input:

//    42 

//    where:

//Input represents the temperature in centigrade.
//Output:

//    Its very hot


using System;

namespace Asst1
{
    class Program
    {
        static void X(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            if (t < 0) {
                Console.WriteLine("Freezing weather");
            }
            else if (t >= 0 && t<10) {
                Console.WriteLine("Very cold weather");
            }
            else if (t >= 10 && t < 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (t >= 20 && t < 30)
            {
                Console.WriteLine("Normal in temperature");
            }
            else if (t >= 30 && t < 40)
            {
                Console.WriteLine("Its Hot");
            }
            else
            {
                Console.WriteLine("Its Very Hot");
            }
        }
    }
}
