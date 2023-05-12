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
            empWageBuilderArray .addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilderArray .addCompanyEmpWage("Reliance", 10, 4, 20);
            Console.ReadKey(); ;
        }
    }
}
