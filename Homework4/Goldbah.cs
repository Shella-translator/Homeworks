bool IsPrime(int number) {
    for (int i = 2; i < number; i++) {
        if (number % i == 0)
            return false;
    }
    return true;
}

Console.Clear();
Console.WriteLine("Гипотеза Гольдбаха");

Console.WriteLine();
Console.Write("Введите четное число, большее чем 2: ");
int N = Convert.ToInt32(Console.ReadLine());

while ((N <= 2) || (N % 2 == 1)) {
    Console.Write("Ошибка ввода. Введите четное число, большее чем 2: ");    
    N = Convert.ToInt32(Console.ReadLine());
}

for (int i = 2; i < N-1; i++) {
    if (IsPrime(i) && IsPrime(N-i)) {
        Console.WriteLine($"Искомая пара простых чисел: {i}, {N-i}");
        break;    
    }
}