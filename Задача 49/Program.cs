void Input(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
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
void Release(int[,] matrix)
{
    for(int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for(int j = 1; j < matrix.GetLength(1); j += 2)
            matrix[i, j] = matrix[i, j] * matrix[i, j];
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
Release(matrix);
Print(matrix);