using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    //Generics
    class GenericsDemo
    {
    }
    public class Calculator
    {
        //var  = compile time check. implicitly type
        //dynamic= runtime check
        public static bool AreEqual<T1,T2>(T1 value1,T2 value2)
        {
            //var abc = 100;
            //var xyz = "100";

            //int num1 = abc;
            //var num2 = xyz;

            //var x = value1;
            //var y = value2;
            //Console.WriteLine(x + y);

            //dynamic a = value1;
            //dynamic b = value2;
            //Console.WriteLine(a + b);
            return value1.Equals(value2);
        }

        public void data()
        {

        }
    }
}
