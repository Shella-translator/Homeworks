public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите количество элементов массива N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите массив: ");
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine("Введите число X: ");
        int X = int.Parse(Console.ReadLine());

        int B = 0;
        foreach (int num in A)
        {
            if (num == X)
            {
                B++;
            }
        }

        Console.WriteLine($"Число X в массиве встречается {B} раз");
    }
}