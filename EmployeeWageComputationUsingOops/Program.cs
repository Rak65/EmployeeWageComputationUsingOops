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
            CheckEmp empWage = new CheckEmp();
            empWage.ComputeEmpWage();
            Console.ReadKey();
        }
    }
}
