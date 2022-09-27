Console.WriteLine("Введите длину сторон треугольника");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());
if (a + b <= c || a + c <= b || b + c <= a)
    Console.WriteLine("Это не треугольник");  
else
    Console.WriteLine("Это треугольник");  