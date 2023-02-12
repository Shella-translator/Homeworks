int[] createRndArray(int N, int min, int max)
{
         int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(min, max + 1);
     }
     return array;
 }

 void printArray(int[] array)
 {
     System.Console.WriteLine(string.Join(" ", array));
      }

 int inputNumber(string text) 
 {
     System.Console.Write(text);
     int number = int.Parse(Console.ReadLine());
     return number;
 }

 int oddSum(int[] array)
 {
     int sum = 0;
     for (int i = 1; i < array.Length; i += 2)
     {
         sum += array[i];
     }
    return sum;
 }

 int[] myArray;

 int lenArray = inputNumber("Введите длину массива: ");

 myArray = createRndArray(lenArray, -100, 100);

printArray(myArray);

 System.Console.WriteLine($"Сумма элементов на нечетных позициях = {oddSum(myArray)}");