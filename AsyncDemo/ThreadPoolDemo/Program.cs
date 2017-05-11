using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue the task.
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));

            Console.WriteLine("Main thread does some work, then sleeps.");

            Thread.Sleep(1000);

            Console.WriteLine("Main thread exits.");
            Console.ReadKey();
        }
        static void ThreadProc(Object stateInfo)
        {
            // No state object was passed to QueueUserWorkItem, 
            // so stateInfo is null.
            Console.WriteLine("Hello from the thread pool.");
        }
        public static void print(int id)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Task {0},ID:cycle{1} ", Thread.CurrentThread.ManagedThreadId.ToString(), id.ToString());
            }
        }
    }
}
