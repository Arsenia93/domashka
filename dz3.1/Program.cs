// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом

Console.WriteLine(" Введите пятизначное число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = 0;

int numberPosition (int number, int a)
{
    int b = 10;
    int i = 1;
    int result = 0;
    while (i < a)
    {
        b = b*10;
        i = i +1;
    }
    result = number % b / (b / 10);
    return result;
}
number2 = numberPosition(number1,1) * 10000 + numberPosition (number1,2) * 1000 + numberPosition (number1,3) * 100 + numberPosition (number1,4) * 10 + numberPosition (number1,5);
if (number2 == number1)
Console.WriteLine("Это палиндром");
else
Console.WriteLine("Это не палиндром");