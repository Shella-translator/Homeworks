using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        char[] chs = s.ToCharArray();

        Perm(chs, 0);
    }

    public static void Perm(char[] chs, int i)
    {
        if (i == chs.Length)
        {
            Console.WriteLine(chs);
            return;
        }

        for (int j = i; j < chs.Length; j++)
        {
            Swap(ref chs[i], ref chs[j]);
            Perm(chs, i + 1);
            Swap(ref chs[i], ref chs[j]);
        }
    }

    public static void Swap(ref char a, ref char b)
    {
        char temp = a;
        a = b;
        b = temp;
    }
}
