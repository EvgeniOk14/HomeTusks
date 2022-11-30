Console.Clear();
Console.WriteLine("Введите целое число N: ");

  double N = Convert.ToDouble(Console.ReadLine());
  if (N % 2 == 0) 
  {
    Console.WriteLine(N + " это чётное число ");
  }
     
  else
  {
    Console.WriteLine(N + " это нечётное число ");
  }
  