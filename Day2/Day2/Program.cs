using System;

namespace Day2
{
    class Emp : object
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            return $"[사원]{name}";
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
