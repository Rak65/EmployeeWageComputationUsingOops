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
            CheckEmp attendance = new CheckEmp();
            attendance.EmployeeAttendance();
            Console.ReadKey();
        }
    }
}
