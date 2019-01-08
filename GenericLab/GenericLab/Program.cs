/*
아래 예제는 int형 스택, string형 스택을 각각 구현했다.
이를 일반화 시켜 Generic으로 Stack 클래스를 구현하고 메인을 적절히 수정하여 테스트 하세요.
*/
using System;

namespace GenericLab
{
    class Stack1
    {
        int top = 0;
        int[] ar = new int[10];
        public void Push(int obj)
        {
            ar[top] = obj;
            top++;
        }
        public int Pop()
        {
            top--;
            return ar[top];
        }
    }
    class Stack2
    {
        int top = 0;
        string[] ar = new string[10];
        public void Push(string obj)
        {
            ar[top] = obj;
            top++;
        }
        public string Pop()
        {
            top--;
            return ar[top];
        }
    }

    class Stack3<T>
    {
        int top = 0;
        T[] ar = new T[10];

        public void Push(T obj)
        {
            ar[top] = obj;
            top++;
        }
        public T Pop()
        {
            top--;
            return ar[top];
        }
    }

    class StackTest
    {
        static void Main()
        {
            Stack1 s1 = new Stack1();
            s1.Push(1);
            s1.Push(2);
            s1.Push(3);
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());
            Stack2 s2 = new Stack2();
            s2.Push("KOREA");
            s2.Push("대한민국");
            s2.Push("서울");
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());
            Console.WriteLine(s2.Pop());

            Console.WriteLine("======================");

            Stack3<int> ss1 = new Stack3<int>();
            ss1.Push(1);
            ss1.Push(2);
            ss1.Push(3);
            Console.WriteLine(ss1.Pop());
            Console.WriteLine(ss1.Pop());
            Console.WriteLine(ss1.Pop());
            Stack3<string> ss2 = new Stack3<string>();
            ss2.Push("KOREA");
            ss2.Push("대한민국");
            ss2.Push("서울");
            Console.WriteLine(ss2.Pop());
            Console.WriteLine(ss2.Pop());
            Console.WriteLine(ss2.Pop());

        }
    }
}