// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    int size = 8;
    int[] V = new int[size];
    Console.WriteLine(" Введите значение вектора ");
    for (int i = 0; i < size; i++)
    {
        V[i]= Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write("{0}, ",V[i]);
    }
    Console.Write("]");