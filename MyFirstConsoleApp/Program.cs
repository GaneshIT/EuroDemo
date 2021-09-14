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

            FileHandling objFile = new FileHandling();

             //string msg= objFile.WriteFile();

            //Console.WriteLine(msg);
            Console.WriteLine("***********");
            Console.WriteLine(objFile.ReadFile());
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
