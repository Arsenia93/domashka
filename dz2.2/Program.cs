// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine(" Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 10;
int c = 0;

if (a>100)
{
    do
    {
    c = a%b;
    b = b*10;
    }
    while (b*10<a);
    Console.WriteLine(a);
    Console.WriteLine(c/(b/100));
}
else 
{Console.WriteLine(a);
Console.WriteLine("третьей цифры нет");
}
