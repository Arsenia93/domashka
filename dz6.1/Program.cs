// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.

Console.WriteLine(" Введите количество чисел ");
int M = Convert.ToInt32(Console.ReadLine());
if (M > 0)
{
    int morethanzero = 0;
    int[] numbers = new int[M];
    Console.WriteLine(" Введите числа ");
    for (int i = 0; i < M; i++)
    {
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        if (numbers[i] > 0)
        morethanzero++; 
    } 
    Console.WriteLine(" Положительных чисел ");
    Console.WriteLine(morethanzero);    
} 
