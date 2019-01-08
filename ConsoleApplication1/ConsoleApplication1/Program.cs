/**
9.다음과 같이 출력결과를 만들어내는 C# 프로그램을 작성하세요.

출력을 원하는 구구단 단수 : 3

1x2 = 2, 2x2 = 4, 3x2 = 6
1x3 = 3, 2x3 = 6, 3x3 = 9
1x4 = 4, 2x4 = 8, 3x4 = 12
1x5 = 5, 2x5 = 10, 3x5 = 15
1x6 = 6, 2x6 = 12, 3x6 = 18
1x7 = 7, 2x7 = 14, 3x7 = 21
1x8 = 8, 2x8 = 16, 3x8 = 24
1x9 = 9, 2x9 = 18, 3x9 = 27
*/

using System;
namespace test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("출력을 원하는 구구단 단수 : ");
            string str = Console.ReadLine();

            if (!isNumYN(str))
            {
                Console.WriteLine("숫자만 입력해 주세요!");
                Environment.Exit(0);
            }

            Console.WriteLine();
            int m = Convert.ToInt32(str);
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    Console.Write($"{j} x {i} = {j * i}"+ ((j < m) ? ", " : ""));
                }
                Console.WriteLine();
            }
        }

        public static bool isNumYN(string str)
        {
            int m = 0;
            bool isNum = int.TryParse(str, out m);
            return isNum;
        }
    }
}