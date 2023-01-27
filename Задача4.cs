Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int l = Convert.ToInt32(Console.ReadLine());
int max = n;
if (max < m)
    max = m;
if (max < l) 
    max = l;
Console.WriteLine($"{max} максимальное из трех чисел");
