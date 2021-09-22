using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelAsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function started");
            MovieBooking movieBooking = new MovieBooking();
            //Task bookingtask = new Task(movieBooking.BookTicket);
            //Task printtask = new Task(movieBooking.PrintTicket);
            //Task cancelbookingtask = new Task(movieBooking.CancelTicket);

            //bookingtask.Start();
            //printtask.Start();
            //cancelbookingtask.Start();
            //Console.WriteLine("Asyn completed");
            // 10L   5L = samsung M2  == 5L req to server
            //movieBooking.BookTicket();
            Thread movieTask1 = new Thread(movieBooking.BookTicket);

            //movieBooking.PrintTicket();
            Thread movieTask2 = new Thread(movieBooking.PrintTicket);

            //movieBooking.CancelTicket();
            Thread movieTask3 = new Thread(movieBooking.CancelTicket);

            movieTask1.Start();
            movieTask2.Start();
            movieTask3.Start();
            Console.WriteLine("Function completed");
            ////odd or even   -  input -> user   =100

            ////Odd number: 1  Threadid=1

            ////Even num:  thr
            //int value = 10;
            //Console.WriteLine("Sequential programming");
            //for (int i = 0; i < 1000000; i++)
            //{               
            //    Console.WriteLine($"value: {i},thread={Thread.CurrentThread.ManagedThreadId }");
            //    Thread.Sleep(1000);
            //}
            //Console.WriteLine("**************");

            //Console.WriteLine("Parallel programming");
            //List<object> stockObj = new List<object>();
            //Parallel.ForEach(stockObj, i =>
            //  {
            //      Console.WriteLine($"value: {i},thread={Thread.CurrentThread.ManagedThreadId }");
            //      sales.GetSalesdata(i);
            //  });

            Console.Read();
        }
    }
    class sales
    {
        public static void GetSalesdata(dynamic salesId)
        {
            long totalSize = 0;
            if (!Directory.Exists("DirectoryName"))
            { 
                Console.WriteLine("The directory does not exist."); 
                return; 
            }

            String[] files = Directory.GetFiles("DirectoryName"); 
            Parallel.For(0, files.Length, index => { FileInfo fi = new FileInfo(files[index]);
                long size = fi.Length; Interlocked.Add(ref totalSize, size); });
            Console.WriteLine("Directory '{0}':", "DirectoryName");
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
            List<object> result = new List<object>();
        }
    }
}
/*
 * T1=> acno=124,T2=> acno=4001 ,T3=> acno=123          =>    var acno=123;
 */