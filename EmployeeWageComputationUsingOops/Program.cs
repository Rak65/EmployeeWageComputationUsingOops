using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("DMart", 20, 20, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 20, 19, 10);
            empWageBuilderArray.computeEmpWage();
            Console.WriteLine("\nTotal Emp Wage for DMart company: {0}", empWageBuilderArray.getTotalWage("DMart"));
            Console.WriteLine("Total Emp Wage for Reliance company: {0}", empWageBuilderArray.getTotalWage("Reliance"));
            Console.ReadKey(); ;
        }
    }
}
