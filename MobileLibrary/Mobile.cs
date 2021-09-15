using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    public class Mobile
    {
       public void MobileTypes()
        {
            Console.WriteLine("Mobile Types");
            Console.WriteLine("Android");
            Console.WriteLine("IOS");          
        }
       public void MobileModels(string mobiletype)
        {
            if (mobiletype == "Android")
            {
                Console.WriteLine("Vivo");
                Console.WriteLine("Samsung");
                Console.WriteLine("Vivo");
            }
            if (mobiletype == "IOS")
            {
                Console.WriteLine("Apple");           
            }
        }
    }
}

//adding a class
//adding a class lib
