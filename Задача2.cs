Console.Clear();
int max = 0;
int min = 0;

Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if(first > second)
{
    max = first;
    min = second;
}
else
{
    max = second;
    min = first;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);