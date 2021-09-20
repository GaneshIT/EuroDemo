using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class DelegateDemo
    {
        //its type that represents references to methods with a particular
        //parameter list and return type

        //type -- class,delegate, interface
    }
    public delegate bool EligbleToPromotion(Employee EmployeeToPromotion);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        

        public static void PromoteEmployee(List<Employee> lstEmployees,EligbleToPromotion isEmployeeEligible)
        {
            foreach (Employee employee in lstEmployees)
            {
                if (isEmployeeEligible(employee))
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }
        public static void data(customer cust,Employee emp,List<customer> lstcust,List<Employee> lstemp)
        {

        }
    }

    public class customer
    {

    }
}
