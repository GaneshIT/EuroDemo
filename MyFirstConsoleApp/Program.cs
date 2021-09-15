using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileLibrary;


namespace MyFirstConsoleApp
{
    class Program
    {
       //var1  interest =6  main()
       // var1     interest = 8   getemployeefun()
        static void Main(string[] args)
        {
            Mobile mobile = new Mobile();
            Samsung samsung = new Samsung();
            Airtel airtel = new Airtel();
            airtel.showRecords();
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
    }
}

//dll files
