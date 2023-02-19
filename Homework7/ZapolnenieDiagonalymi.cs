void DiagInp(int[,] matrix)
{
    int i, j, row = 0, col = 0, n = 0;
    while (row <= matrix.GetLength(0) - 1)
    {
        i = row;
        j = col;
        while (i < matrix.GetLength(0) && j >= 0)
        {
            matrix[i++, j--] = n++;
        }
        if( col < matrix.GetLength(1) - 1) col++;
        else row++;
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите размеры массива через пробел: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int r = size[0] * size[1];
DiagInp(matrix);
PrintMatrix(matrix);