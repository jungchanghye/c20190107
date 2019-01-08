using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Test
{
    public class Tester
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Enumerable.Range(1, 10000).Sum(o => o.ToString().Count(n => n == '7')));
        }

        public static void searchSeven(int num)
        {
            int count = 0;
            if (num % 10 == 7) count++;
            if (num > 10) searchSeven(num / 10);
        }
    }
}