//Calculate the Gross Salary


//Given basic salary as an input, calculate the gross salary according to the given conditions:

//If Basic Salary <= 10000 : HRA = 20%, DA = 80%
//If Basic Salary is between 10001 to 20000 : HRA = 25%, DA = 90%
//If Basic Salary >= 20001 : HRA = 30%, DA = 95%
 
//Input:

//    22000

//    where:

//Input is the basic salary of an employee.
//Output:

//    49500.00

//Explanation: Output displays the Gross Salary of the employee according to the given conditions.

using System;
namespace Asst1
{
    public class Program3
    {
        static void Main(string[] args)
        {
            var salary = float.Parse(Console.ReadLine());
            var netSalary = 0.0;
            if (salary <= 10000) {
                netSalary = salary + salary * 0.2 + salary * 0.8;
            }
            else if (salary >10000 && salary <= 20000)
            {
                netSalary = salary + salary * 0.25 + salary * 0.9;
            }
            else
            {
                netSalary = salary + salary * 0.3 + salary * 0.95;
            }
            Console.WriteLine(netSalary);
        }
    }
}
