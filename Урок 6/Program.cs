Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrFirst = new int[n];
int[] arrResult = new int[n];

Console.WriteLine("Заполните массив");
for (int i = 0; i < arrFirst.Length; i++)
    arrFirst[i] = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine("[" + string.Join(", ", arrFirst) + "]");

Console.WriteLine("Насколько сдвигаем массив");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i ++)
        arrResult[i] = arrFirst[arrFirst.Length - k + i];

    Console.WriteLine("[" + string.Join(", ", arrResult) + "]");

    for (int i = 0; i < n - k; i++)
        arrResult[k + i] = arrFirst[i];

    Console.WriteLine("[" + string.Join(", ", arrResult) + "]");
}
else
{
    k = (-1) * k;
     for (int i = 0; i < k; i ++)
        arrResult[arrFirst.Length - k + i] = arrFirst[i];

    Console.WriteLine("[" + string.Join(", ", arrResult) + "]");

    for (int i = 0; i < n - k; i++)
        arrResult[i] = arrFirst[k + i];

    Console.WriteLine("[" + string.Join(", ", arrResult) + "]");
}