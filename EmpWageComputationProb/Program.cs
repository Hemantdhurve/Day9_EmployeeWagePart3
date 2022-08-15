using System;

namespace EmpWageComputationProb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Problem Part 3");

            Console.WriteLine("Check whether employee is Present or Absent");
            //Creating Object of the class to call in Main method
            //because method is non static

            EmployeeWage emp1 = new EmployeeWage();
            emp1.EmployeeCheckAttendance();
        }
    }
}