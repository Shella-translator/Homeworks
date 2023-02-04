Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.Write($"{n} -> ");
while (i < n)
{
    Console.Write($"{i * i * i}, ");
    i++;
}
Console.Write($"{i * i * i}");