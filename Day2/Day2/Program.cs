using System;

namespace Day2
{
    class Emp : object
    {
        public string Name //자동구현속성
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"[사원]{Name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Name = "홍";

            Console.WriteLine(e.Name);
        }
    }
}
