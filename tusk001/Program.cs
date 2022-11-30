Console.Clear();
Console.Write("Введите первое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первое число N равно: " + N);
Console.Write("Введите второе число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число M равно: " + M);
int Max = N;
int Min = M;
  if (N > M) 
  {
     N = Max;
     Console.WriteLine("наибольшее из двух чисел N и M является число: " + N);
  }
  if (M > N)
  {
    M = Max;
    Console.WriteLine("наибольше из двух чисел N и M является число: " + M);
  }
      if (N == M)
      {
        Console.WriteLine("Оба числа равны: " + N + " = " + M);

      }