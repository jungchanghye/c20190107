using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class Program
    {
        // 1. 선언
        //delegate int SumDelegate(int i, int j);        

        static void Main(string[] args)
        {
            // 2. 생성
            //SumDelegate s = new SumDelegate(Sum);
            //Func<int, int, int> s = new Func<int, int, int>(Sum);
            Func<int, int, int> s = Sum;

            // 3. 실행
            Console.WriteLine(s(1, 2));

            Program p = new Program();
            Func<int, int, int> s2 = p.Sum2;

            Console.WriteLine(s2(2, 4));
        }

        static int Sum(int i, int j)
        {
            return i + j;
        }

        int Sum2(int i, int j)
        {
            return i + j;
        }
    }
}