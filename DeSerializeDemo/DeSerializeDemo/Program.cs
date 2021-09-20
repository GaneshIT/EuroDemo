using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using SerializeDll;
namespace DeSerializeDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var binaryFormatter = new BinaryFormatter();
            Stream fs = new FileStream(@"C:\Training\EuroTraining\Files\tutorial.txt", FileMode.Open, FileAccess.Read);
            var tutorial1 =(Tutorial) binaryFormatter.Deserialize(fs);
            //Console.WriteLine(tutorial1.ID);
            //Console.WriteLine(tutorial1.Name);
        }
    }
}

