Console.WriteLine("Введите число в десятичнос системе");
int n = Convert.ToInt32(Console.ReadLine());
string result = "";
while (n > 0)
{
    int x = n % 2;
    result = Convert.ToString(x) + result;
    n = n / 2;
}
Console.WriteLine(result);

