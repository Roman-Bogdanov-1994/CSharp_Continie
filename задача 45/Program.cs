Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrFirst = new int[n];
int[] arrResult = new int[n];

for (int i = 0; i < arrFirst.Length; i++)
    arrFirst[i] = new Random().Next(1, 10);

Console.WriteLine("[" + string.Join(", ", arrFirst) + "]");

for (int i = 0; i < arrFirst.Length; i++)
    arrResult[i] = arrFirst[i];

Console.WriteLine("[" + string.Join(", ", arrResult) + "]");