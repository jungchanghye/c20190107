using System;

namespace ArrayTest2
{
    class Program
    {
        static int[] iArr = new int[10]; //배열선언
        static Random r = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                iArr[i] = r.Next(1, 10);                
            }

            foreach(int i in iArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }//
}
