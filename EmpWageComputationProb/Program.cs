using System;

namespace EmpWageComputationProb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Part 3");

            Console.WriteLine("Output of Total Employee wage of Multiple Companies are :");
            //Creating Object of the class to call in Main method
            //because method is non static

            EmployeeWage emp = new EmployeeWage();
            emp.computeEmpWage("DMart", 20, 2, 10);
            emp.computeEmpWage("Reliance", 10, 4, 20);

        }
    }
}