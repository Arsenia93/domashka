// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    for (int i = 1; i <= n; i = i + 1)
    Console.Write("{0}, ",i*i*i);
} else
{
    Console.WriteLine("Введено не корректное число");
}