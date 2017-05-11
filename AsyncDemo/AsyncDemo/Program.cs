using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            for (int i = 0; i < 5; i++)
            {
                int id = i;
                Task.Run(() => print(id));
                //task.Start();
            }
            
            
            Console.ReadKey();
        }
        public static void print(int id)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Task {0},ID:cycle{1} ", Thread.CurrentThread.ManagedThreadId.ToString(),id.ToString());
            }
        }
    }
}
