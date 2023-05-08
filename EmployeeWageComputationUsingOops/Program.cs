using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Company name : ");
            String company = Console.ReadLine();
            Console.WriteLine("Enter Employee rate per hour : ");
            int EMP_RATE_PER_HOUR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of working days :");
            int NO_OF_WORKING_DAYS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maximum working hour in a month :");
            int MAX_WORKING_HOUR = Convert.ToInt32(Console.ReadLine());
            CheckEmp compute = new CheckEmp();
            compute.ComputeEmpWage(company, EMP_RATE_PER_HOUR, NO_OF_WORKING_DAYS, MAX_WORKING_HOUR);
            Console.ReadKey(); ;
        }
    }
}
