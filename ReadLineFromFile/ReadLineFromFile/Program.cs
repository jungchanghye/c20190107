using System;
using System.IO;

namespace ReadLineFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum(@"C:\GitHub\c20190107\number.txt");
            Console.WriteLine(sum);
        }

        static int Sum(string file)
        {
            int sum = 0;
            string[] arr = File.ReadAllLines(file);

            foreach(string i in arr)
            {
                sum += Convert.ToInt32(i);
            }
            return sum;
        }
    }
}
