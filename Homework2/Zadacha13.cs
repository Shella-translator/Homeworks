Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n;
if (n < 100)
{
    Console.WriteLine($"{n} -> третьей цифры нет ");
}
else
{
    while (n1 >= 1000)
    { 
        n1 = n1 / 10;
    }
    Console.WriteLine($"{n} -> {n1 % 10 % 10}");
}