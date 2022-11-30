Console.Clear();
Console.Write("Введите первое число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Первое число n равно: " + n);
Console.Write("Введите второе число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число m равно: " + m);
Console.Write("Введите третье число k: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число k равно: " + k);
int max = 0;
int min = 0;

 if (n > m && n > k)
 {
    max = n;

    Console.WriteLine("Максимальное из трёх чисел равно: " + max);
 }
     if (m > k && m > n)
    {
        max = n;
       Console.WriteLine("Максимальное из трёх чисел равно: " + max);  
    }
     if (k > n && k > m)
     {
        max = k;
         Console.WriteLine("Максимальное из трёх чисел равно: " + max);
     }



      else if (n == m && n > k || m > k)
     {
        max = n = m;
         Console.WriteLine("Из трёх чисел два максимальных числа n = " + n + ", m = " + m);

     }
      else if (k == n && k > m || n > m)
      {
        max = k = n;
        Console.WriteLine("Из трёх чисел два максимальных числа k =  " + k + ", m = " + n);
      }

      else if (k == m && k > n || m > n)

      {
        max = k = m;
        Console.WriteLine("Из трёх чисел два максимальных числа k = " + k + ", m =  " + m);
      }
      
        else if (m == n && m == k && n ==k)
        {
            max = n = m = k;
            Console.WriteLine("Все три числа равны: " + max);
        }
  