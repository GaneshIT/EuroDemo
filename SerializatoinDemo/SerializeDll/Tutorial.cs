using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDll
{
    [Serializable]
   public class Tutorial
    {
        public int ID;
        public String Name;
        public void CreateTutorial()
        {
            Tutorial tutorial = new Tutorial();
            tutorial.ID = 1;
            tutorial.Name = "C#";



            var binaryFormatter = new BinaryFormatter();
            Stream fs = new FileStream(@"C:\Training\EuroTraining\Files\tutorial.txt", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fs, tutorial);

            fs.Close();
            //fs = new FileStream(@"C:\Training\EuroTraining\Files\tutorial.txt", FileMode.Open, FileAccess.Read);
            //var tutorial1 = (Tutorial)binaryFormatter.Deserialize(fs);
            //Console.WriteLine(tutorial1.ID);
            //Console.WriteLine(tutorial1.Name);

        }
    }
}
