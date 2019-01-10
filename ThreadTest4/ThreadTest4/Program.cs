using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ConsoleApplication3
{
    class Program
    {
        static int mysum = 0;
        static void Sum(object n)
        {
            int sum = 0;
            int[] number = (int[])n;
            for (int i = number[0]; i <= number[1]; i++)
            {
                sum += i;
            }
            mysum += sum;
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t2 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t3 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t4 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t5 = new Thread(new ParameterizedThreadStart(Sum));

            t1.Start(new int[] { 1, 20 }); t2.Start(new int[] { 21, 40 });
            t3.Start(new int[] { 41,60 }); t4.Start(new int[] { 61, 80 });
            t5.Start(new int[] { 81, 100 });
            t1.Join(); t2.Join(); t3.Join(); t4.Join(); t5.Join();
            Console.WriteLine("1부터00까지의 합은 :: {0}", mysum);
        }
    }
}