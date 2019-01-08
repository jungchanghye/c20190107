using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTest
{
    class Emp
    {
        public string name;
        public static string compName;
        public void GoToOffice()
        {
            Console.WriteLine($"{compName} 소속 {name}(이)가 출근합니다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp.compName = "탑크리에듀";
            Emp e = new Emp();
            e.name = "홍길동";

            e.GoToOffice();
        }
    }
}
