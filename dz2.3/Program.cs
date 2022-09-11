// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine(" Введите номер дня недели ");
int b = Convert.ToInt32(Console.ReadLine());

if (b>0 && b<6) 
Console.WriteLine("нет, это будний день");
else    
if (b>=6 && b<8) 
Console.WriteLine("да, это выходной");
else 
Console.WriteLine("некорректные данные");
