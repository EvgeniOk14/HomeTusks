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

    for (int i = 1; i < array.Length - 1; i++)
    {
             int indexForMin = i;

               for (int j = i +1; j < array.Length; j++)
                  {
                      if (array[j] < array[indexForMin])
                          {
                             indexForMin = j;
                          }  
                    int temp = array[i];
                    array[i] = array[indexForMin];
                    array[indexForMin] = temp;
                          
                   }
    }
    Console.WriteLine();
}

    int [] array = new int[10];

    FillArray(array); 
    PrintArray(array);
    SelectionSort(array);
    PrintArray(array);
    