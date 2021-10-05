using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    //It allows you to fetch Type (Assembly) information at runtime or programmatically
    /*
     * Assemblies contain modules
       Modules contain types
       Types contain members

    class EB{
    consumerno, name, totalunits,totalamount, 
    
    discount

    if(totalunits>100)
    discount=1%
    list.add(discount);

    ProertypinfoClass =EB
    foreach(propertyinfo property in ProertypinfoClass[]){
    property.name=
    property.type

    list.add(property)
    }

    }

    type date



     */
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductId = 11;
            product.ProductName = "Sony";
            product.Price = 200;
            product.InsertProduct();

            Type t = typeof(Product);
            
            var members = t.GetMethods();
            var properties = t.GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Name.GetType().Name);
                if (item.Name == "Price")
                {
                    //item.SetValue(item, 10);
                    //item.SetValue(t, 10);
                    //Console.WriteLine(item.GetValue(item.Name));
                }
                
                
            }
            object productobj = Activator.CreateInstance(t);
            foreach (var item in members)
            {
                if (item.Name == "InsertProduct")
                {
                    item.Invoke(productobj, null);
                }
                Console.WriteLine(item.Name);
            }

            EvenOdd evenOdd = new EvenOdd();
            //Thread t1 = new Thread(evenOdd.Evenn);
            //Thread t2 = new Thread(evenOdd.Oddd);

            Task tt = new Task(()=>
            {
                evenOdd.Evenn("t");
            });
            
            tt.Start();

            Console.Read();
        }

    }

   public class EvenOdd
    {
        public void Evenn(object a)
        {

        }
        public void Oddd(object a)
        {

        }
    }
}
