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

int count = 0;
void Release(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            if (i == j)
                count = count + matrix[i, j];
        
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
Console.WriteLine();
Console.Write("Сумма чисел диагонали = ");
Console.WriteLine(count);