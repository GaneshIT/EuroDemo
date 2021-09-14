using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstConsoleApp
{
    class FileHandling
    {
        // no retrun - void
        // return - int, string, flot,  double, decimal,etc.
        //acces specifiers: public,private,internal,protected, protected internal
       public string WriteFile()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\temp.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Welcome to training");
            sw.WriteLine("*******************");
            sw.WriteLine("Java");
            sw.WriteLine("C#");
            sw.WriteLine("Javascript");
            sw.WriteLine("HTML5");
            sw.Close();
            fs.Close();
            return "File created";
        }
       public string ReadFile()
        {
            string[] files = Directory.GetFiles(@"C:\Training\EuroTraining\Files");
            for (int i = 0; i < files.Length; i++)
            {
                FileStream fs = new FileStream(files[i], FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() > 0)
                {
                    string line = sr.ReadLine();
                    if (line.Contains(":"))
                    {
                        string[] courses = line.Split(':');
                        for (int j = 0;  j< courses.Length; j++)
                        {
                            Console.WriteLine(courses[j]);
                        }
                        Console.WriteLine("************");
                        //Console.WriteLine(line);
                    }
                    
                }
                fs.Close();
            }
            
            return "Read success";
        }
    }
}
/*
Course details:
enter number courses: 2

Enter regno: 123
enter course:BE
enter course title:java

Enter regno: 124
enter course:BE
enter course title:C#

File:
Course details
*************
Number of courses:2
RegNo:123
course:BE
title:java

RegNo:124
course:BE
title:c#


Mobile Network performance
*****************************
Source      Destination      Date     call-status
867334343   3243243423      23:2:2021   Missed







 */