using System;

public class Program
{
    public static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var x1 = int.Parse(line[0]);
        var y1 = int.Parse(line[1]);
        var x2 = int.Parse(line[2]);
        var y2 = int.Parse(line[3]);
        var x3 = int.Parse(line[4]);
        var y3 = int.Parse(line[5]);

        var a = Math.Sqrt(Math.Abs(x2 - x1) * Math.Abs(x2 - x1) + Math.Abs(y2 - y1) * Math.Abs(y2 - y1));
        var b = Math.Sqrt(Math.Abs(x2 - x3) * Math.Abs(x2 - x3) + Math.Abs(y2 - y3) * Math.Abs(y2 - y3));
        var c = Math.Sqrt(Math.Abs(x1 - x3) * Math.Abs(x1 - x3) + Math.Abs(y1 - y3) * Math.Abs(y1 - y3));

        var p = (a + b + c) / 2;
        var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        if (Math.Abs(s - (int)s) < 0.00001)
        {
            Console.WriteLine((int)s);
        }
        else
        {
            Console.WriteLine(Math.Round(s, 1));
        }
    }
}