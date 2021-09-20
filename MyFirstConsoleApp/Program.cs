using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileLibrary;


namespace MyFirstConsoleApp
{
    public delegate bool FilterDelegate(Person p);
    class Program
    {
       //var1  interest =6  main()
       // var1     interest = 8   getemployeefun()
        static void Main(string[] args)
        {
            //genericsdemo
            //bool result = Calculator.AreEqual<int,string>(20, "30");
            ////result = Calculator.AreEqual<string>("20", "30");
            //Console.WriteLine(result);

            //delegatesdemo
            //Employee emp1 = new Employee()
            //{
            //    ID = 1,
            //    Name = "Raj",
            //    Experience = 2,
            //    Gender = "M",
            //    Salary = 4000
            //};
            //Employee emp2 = new Employee()
            //{
            //    ID = 2,
            //    Name = "vasu",
            //    Experience = 4,
            //    Gender = "M",
            //    Salary = 7000
            //};
            //Employee emp3 = new Employee()
            //{
            //    ID = 3,
            //    Name = "Vinitha",
            //    Experience = 3,
            //    Gender = "F",
            //    Salary = 8000
            //};

            

            //List<Employee> lstemployees = new List<Employee>();
            //lstemployees.Add(emp1);
            //lstemployees.Add(emp2);
            //lstemployees.Add(emp3);

            //EligbleToPromotion eligbleToPromotion = new EligbleToPromotion(Program.Promote);
            //Employee.PromoteEmployee(lstemployees, eligbleToPromotion);

            //customer objcust = new customer();
            //List<customer> lstcustomers = new List<customer>();
            //Employee.data(objcust, emp1, lstcustomers, lstemployees);

            //Mobile mobile = new Mobile();
            //Samsung samsung = new Samsung();
            //Airtel airtel = new Airtel();
            //airtel.showRecords();
            //int a = 10;
            //string b = a.ToString();

            //string c = "10";
            //object d = c;

            //int x = 20;
            //object xx = 20;       //boxing- value type to ref

            //int value =Convert.ToInt32(xx);  //unboxing- ref to value

            //float m = 20;
            //object mm = m;



            //EmployeeCompensation objemp = new EmployeeCompensation();
            //objemp.EmployeeBonus();
            //int interest;
            //EmployeeCompensation.GetEmployeeInterest(out interest);
            //Console.WriteLine(interest);
            //EmployeeCompensation.EmployeeDept("IT", "Sales", "Production","Stock",10);
            //MobileServices mobileServices = new MobileServices();
            //mobileServices.ServiceTypes();
            //Mobile objmobile = new Mobile();
            //objmobile.MobileModels("");

            //FileHandling objFile = new FileHandling();

            // //string msg= objFile.WriteFile();

            ////Console.WriteLine(msg);
            //Console.WriteLine("***********");
            //Console.WriteLine(objFile.ReadFile());
            //string a = null;
            //Console.WriteLine(Convert.ToInt32(a));
            //Convert.ToString(objFile.ReadFile());
            //Console.WriteLine("WriteFile: " + objFile.WriteFile());
            //Console.WriteLine("ReadFile: " + objFile.ReadFile().ToString());
            //int value, value2, value3;
            //Console.WriteLine("Enter value1:");
            //value = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter value2:");
            //value2 = Convert.ToInt32(Console.ReadLine());
            //value3 = value + value2;

            //Console.WriteLine("addition:" + (value + value2));
            ////20   30      2030
            ////ctrl k+c
            ////ctrl k+u
            ///
            Console.Read();
        }
        
        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 5000)
                return true;
            else
                return false;
        }

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }

            Console.Write("\n\n");
        }
    }
}

//dll files
