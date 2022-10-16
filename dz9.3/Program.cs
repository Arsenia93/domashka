// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int FunctionAckermann (int M, int N)
{
    if (M == 0)
    return N + 1;
    else if (N == 0)
    return FunctionAckermann (M - 1, 1);
    else 
    return FunctionAckermann(M - 1, FunctionAckermann(M, N - 1));
}
Console.WriteLine("Введите два неотрицательных целых числа m и n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
if (m>=0 && n>=0)
{
    n = FunctionAckermann(m,n);
    Console.WriteLine("Результат функции Аккермана - {0}", n);
} 