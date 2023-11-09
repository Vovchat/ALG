//стр.16 зад.17 Рожков
Console.WriteLine("Введите x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y");
double y = Convert.ToDouble(Console.ReadLine());
if (x * x + y * y <= 25 && x >= 0 && y >= 0 || Math.Abs(x) + Math.Abs(y) <= 5 && x <= 0 && y >= 0 || Math.Abs(x) + Math.Abs(y) <= 5 && x <= 0 && y <= 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}