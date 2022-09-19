// See https://aka.ms/new-console-template for more information
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициент b1: ");
double b1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2: ");
double b2 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1: ");
double k1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2: ");
double k2 = Convert.ToSingle(Console.ReadLine());

double[] Cross(double a1, double a2, double c1, double c2)
{
    double x = (a2 - a1)/(c1 - c2);
    double y = y = c1 * x + a1;
    double[] arr = new double[2] {x, y};
    return arr;
}

double[] res = Cross(b1, b2, k1, k2);
Console.WriteLine(res);