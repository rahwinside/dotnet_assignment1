//Count total number of notes


//Given is an integer, which represents the amount as an input from the user,
//display the minimum number of notes $ (500, 100, 50, 20, 10, 5, 2, 1) required for the amount.

//Input:

//    575

//    where:

//Input is the amount for which we have to calculate the number of notes.
//Output:

//    4

//Explanation: Total amount = 1(500 dollar note) + 1(50 dollar note) + 1(20 dollar note) + 1(5 dollar note) = 575,
//hence the minimum number of notes required is 4.

using System;
namespace Asst1
{
    public class Program5
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var noteCount = 0;
            int[] notes = { 500, 100, 50, 20, 10, 5, 2, 1 };

            while (sum > 0) {
                for (int i = 0; i < notes.Length; i++)
                {
                    if (sum >= notes[i])
                    {
                        sum -= notes[i];
                        noteCount++;
                        break;
                    }
                }
            }
            Console.WriteLine(noteCount);
        }
    }
}
