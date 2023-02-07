void Sum(int number)
{
    int acc = number;
    int sum = 0;

    while (acc > 0)
    {
        sum += acc % 10;
        acc /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Sum(number);