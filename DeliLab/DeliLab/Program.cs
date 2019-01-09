using System;

namespace DeliLab
{
    class Program
    {
        delegate int Calc(int i, int j);

        static void Main(string[] args)
        {            
            Calc c = new Calc(MySum);
            Console.WriteLine("1+2={0}", c(1, 2));

            Calc c1 = delegate (int i, int j)
            {
                return i + j;
            };
            Console.WriteLine("3+4={0}", c1(3, 4));

            Func<int, int, int> cc = MySum;
            Console.WriteLine("1+2={0}", cc(1, 2));

            Func<int, int, int> cc1 = (int i, int j) => i + j;
            Console.WriteLine("3+4={0}", cc1(3, 4));
        }

        static int MySum(int i, int j)
        {
            return i + j;
        }
    }
}
