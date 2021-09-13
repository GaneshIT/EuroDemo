using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int? value1=null,value2,value3;
            Console.WriteLine("Enter value1:");
            value1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value2:");
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = value1 + value2;

            Console.WriteLine("result:"+ value3);
            Console.Read();
        }
    }
}
