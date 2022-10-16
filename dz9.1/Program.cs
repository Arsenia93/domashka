// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
void VyvodChisel (int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        VyvodChisel(n - 1);
        return;   
    }
    else 
    return;
}

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0) 
VyvodChisel(N);