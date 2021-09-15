using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileLibrary
{
    public abstract class Telephone
    {
        public void data()
        {

        }
        public abstract void showRecords();

    }

    public class BSNL : Telephone
    {
        public override void showRecords()
        {
            Console.WriteLine("Employee records");
        }
    }
    public class Airtel : Telephone
    {
        public override void showRecords()
        {
            Console.WriteLine("customer records");
        }

    }
    public class idea 
    {

    }
    public sealed class Security 
    {
        public void setSecurity()
        {

        }
    }
        
}
