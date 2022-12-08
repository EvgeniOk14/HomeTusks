void WriteLength()
{
    Console.WriteLine("Задайте длину массива n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("длина массива равна:" + n);
    Console.WriteLine();
}

void FillArray (int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
      {
        collection[i] = new Random().Next(1,10); 
      }
      Console.WriteLine();
}

void PrintArray(int[] col)
{
  int count = col.Length;
  for (int i = 0; i < count; i++)
    {
       Console.Write(col[i]);
    }
    Console.WriteLine();
}
     
 void SelectionSort(int[] array)
 {

    for (int i = 0; i < array.Length - 1; i++)
       {
         int indexForMin = i;

         for (int j = i + 1; j < array.Length; j++)
                  {
                      if (array[j] < array[indexForMin])
                             indexForMin = j;        
                  }

         int temp = array[i];
         array[i] = array[indexForMin];
         array[indexForMin] = temp;
       }    

    Console.WriteLine();
 }

    int [] array = new int[10];

    WriteLength();
    FillArray(array); 
    PrintArray(array);
    SelectionSort(array);
    PrintArray(array);
   
