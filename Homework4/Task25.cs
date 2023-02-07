Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
int acc = 1;

for (int i = 0; i < degree; i++)
{
    acc = acc * number;
}
Console.WriteLine($"{number} в степени {degree} = {acc}");