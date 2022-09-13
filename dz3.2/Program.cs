// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве

double itog = 0;
double[] a = {};
double[] b = {};

double[] function (int size)
{
    double[] ab = {0,0,0};
    Console.WriteLine(" Введите значение вектора " );
    for (int i = 0; i < size; i = i + 1)
    {
        ab[i] = Convert.ToInt32(Console.ReadLine());
    }
    return ab;
}
a = function (3);
b = function (3);
for (int k = 0; k < 3; k = k + 1)
{
    itog = itog + (a[k] - b[k]) * (a[k] - b[k]);
}
Console.WriteLine(Math.Round(Math.Sqrt(itog),2));