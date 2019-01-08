using System;

namespace ValueRefTest
{
    class Emp
    {
        string name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = new int();
            i = 999;

            Emp e = new Emp();
            e.name = "홍길동";
        }
    }
}
