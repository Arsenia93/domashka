// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
float[] sr = new float [n];
int[,] massive = new int[m,n];

for (int i = 0; i < n; i++)
    {
    sr[i] = 0;
    }

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    massive[i,j] = Convert.ToInt32(Console.ReadLine());
    sr[j] = sr[j] + (float)massive[i,j]/(float)m;
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    Console.Write("{0} ", massive[i,j]);
    }
    Console.WriteLine();
}
 for (int j = 0; j < n; j++)
    {
    Console.Write("{0} ", Math.Round(sr[j],1));
    }