double[] createRndArray(int N, int min, int max) // Создаем массив длиной N из целых чисел в диапазоне [min, max]
{
    double[] array = new double[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void printArray(double[] array) // Выводим массив на экран
{
    System.Console.WriteLine(string.Join(" ", array));
}

int inputNumber(string text) // Считывание числа из консоли. 
{
    System.Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double maxMinusMin(double[] array) // Счмтаем разницу между максимальным и минимальным элементом
{
    double result =0, 
        min = array[0], max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }

        return result = max - min;
}

double[] myArray;

int lenArray = inputNumber("Введите длину массива: ");

myArray = createRndArray(lenArray, -10, 10);

printArray(myArray);

System.Console.WriteLine($"Разница между минимальным и максимальным элементами равна: {maxMinusMin(myArray)}");