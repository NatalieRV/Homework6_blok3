// Найти точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1 = ");
double numberK1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b1 = ");
double numberB1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2 = ");
double numberK2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2 = ");
double numberB2 = Convert.ToInt32(Console.ReadLine());

double resultX = (numberB2 - numberB1) / (numberK1 - numberK2);
double resultY = numberK1 * resultX + numberB1;

Console.WriteLine();
Console.WriteLine($"Точка пересечения двух прямых = ({resultX},{resultY})");

