void Input(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i + j;
    }
}

void Print(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];

Input(matrix);
Print(matrix);