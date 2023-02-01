Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n < 6) 
{
    Console.WriteLine($"{n} -> будний день");
}
else if (n == 6 || n == 7)
{
    Console.WriteLine($"{n} -> выходной");
}
else
{
    Console.WriteLine($"{n} -> такого дня недели нет");
}