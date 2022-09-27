// void InputArray(int[] array)
// {
//         for (int i = 0; i < array.Length; i++)
//             array[i] = new Random().Next(1, 10);
// }

// void Reverse(int[]array)
// {
//         for (int i = 0; i < array.Length / 2; i++)
//         {
//                 int x = array[i];
//                 array[i] = array[array.Length - 1 - i];
//                 array[array.Length - i - 1] = x;
//         }
// }
   
// Console.WriteLine("Введите длину массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Reverse(array);
// Console.WriteLine("[" + string.Join(", ", array) + "]");


Console.WriteLine("Введите длину массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrFirst = new int[n];
int[] arrResult = new int[n];

for (int i = 0; i < arrFirst.Length; i++)
    arrFirst[i] = new Random().Next(1, 10);
    
Console.WriteLine("[" + string.Join(", ", arrFirst) + "]");

for (int i = 0; i < arrFirst.Length; i ++)
    arrResult[i] = arrFirst[arrFirst.Length - i - 1];

Console.WriteLine("[" + string.Join(", ", arrResult) + "]");