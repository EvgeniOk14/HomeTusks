﻿ Console.Clear();
Console.WriteLine("Введате целое положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
   
   
   for (int i = 1; i <= N; i++)
{
     if (i % 2 == 0)
     Console.WriteLine(i + " " );
}
