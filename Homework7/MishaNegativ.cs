void InputPrintPhoto(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j == 0 || i % 2 == 0 && j == 3 ) matrix[i, j] = "W";
            else matrix[i, j] = "B";
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void MakeNegativ(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j == 0 || i >= 1 && j == 3) matrix[i, j] = "B";
            else matrix[i, j] = "W";
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int ChekNegotive(string[,] matrix1, string[,] matrix2)
{
    int fault = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if( matrix1[i, j] == matrix2[i, j]) fault++;
        }
     }
     return fault;
}
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();  
string[,] Photo = new string[size[0], size[1]];
string[,] Negativ = new string[size[0], size[1]];
InputPrintPhoto(Photo);
Console.WriteLine();
MakeNegativ(Negativ);
Console.WriteLine($"Количество ошибок : {ChekNegotive(Photo, Negativ)}");