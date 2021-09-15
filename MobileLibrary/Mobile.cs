using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    public class Mobile
    {
        private int IMENum { get; set; }
        public string processor { get; set; }
        public string internalMemory { get; set; }
        public string RamSize { get; set; }
        public virtual void Dial()
        {
            Console.WriteLine("Dial a number");
        }
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
//OOPS
/*
class & Objects
Abstraction
Encapsulation
Inheritance
Polymorphism
 */
