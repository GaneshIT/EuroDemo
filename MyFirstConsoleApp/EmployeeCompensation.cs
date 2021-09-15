using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class EmployeeCompensation
    {
        public static void EmployeeBonus()
        {
            Console.WriteLine("EmployeeBonus");
        }
        public static void GetEmployeeInterest(out int rateOfinterst)
        {
            rateOfinterst = 8;
            if (rateOfinterst > 5)
            {
                rateOfinterst = rateOfinterst + 2;
            }
            else
            {
                rateOfinterst = rateOfinterst + 5;
            }
        }
        
        public static void EmployeeDept(params object[] dept)
        {
            for (int i = 0; i < dept.Length; i++)
            {

                Console.WriteLine(dept[i]);
            }
        }
    }
    //in for how many process steps: 3,4,5
    //4 steps
    //ref,out, params
    //Static variables are accessed with the name of the class, 
    //they do not require any object for access
}
