
// Console.WriteLine("Введите количество чисел для проверки");
// Console.Write("M = ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[M];
// for (int i = 0; i < array.Length; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//         count++;
// }
//  Console.WriteLine("Положительных чисел " + count);

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
   // Console.WriteLine();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}

void Release(int[,] matrix)
{
    int [,] ResultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            ResultMatrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
        Console.WriteLine();
    }
    Print(ResultMatrix);
}

Console.Write("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];

Input(matrix);
Print(matrix);
Release(matrix);

