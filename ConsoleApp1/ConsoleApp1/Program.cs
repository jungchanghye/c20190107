using System;
using System.Collections.Generic;

public class Test
{
    static void Main()
    {
        string s = "abzcadbadcf";
        char ch = GetFirstChar(s.ToCharArray());
        Console.WriteLine(ch);
    }

    static char GetFirstChar(char[] S)
    {
        Dictionary<char, int> ht = new Dictionary<char, int>();

        foreach (char ch in S)
        {
            if (!ht.ContainsKey(ch))
                ht[ch] = 1;
            else
                ht[ch] += 1;
        }

        foreach (char ch in S)
        {
            if (ht[ch] == 1)
                return ch;
        }

        return '\0';
    }
}
