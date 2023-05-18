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
            Console.ReadKey(); ;
        }
    }
}
