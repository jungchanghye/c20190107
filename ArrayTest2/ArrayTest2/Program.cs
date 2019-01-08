﻿using System;
using System.Linq;
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

            int sum = 0;
            foreach(int i in iArr)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine($"\n배열의 합은 {sum}");
            Console.WriteLine($"배열의 합은 {iArr.Sum()}");
        }
    }//
}
