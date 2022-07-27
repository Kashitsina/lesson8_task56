void Zadacha56()
{
  // Задайте прямоугольный двумерный массив. Напишите программу, 
  //которая будет находить строку с наименьшей суммой элементов.
  
  Random random = new Random();
  int rows = random.Next(2, 6);
  int columns = random.Next(3, 6);
  
 
  int[,] array = new int[rows, columns];
  FillArray(array);
  PrintArray(array);  

  int sumLine = 0;
  int sumLineMin = 0;

  for (int j = 0; j < columns; j++)
  {
    sumLine  += array [0, j];
  }
  Console.WriteLine($"Сумма 1 строки равна: {sumLine}");
  for (int i = 1; i < rows; i++)
  {
     int sum = 0;             
     for (int j = 0; j < columns; j++)
      {
                 
        sum += array[i, j]  ;
      }
      Console.WriteLine($"Сумма {i+1} строки равна: {sum}");
   
    if(sum < sumLine)
    {
      sumLine = sum ;
      sumLineMin = i;
    } 

  }
   Console.WriteLine();
   Console.WriteLine($"Минимальная сумма  находится в строке {sumLineMin  +1 } и равна {sumLine}");



  void FillArray(int[,] array)
            {
                Random random = new Random();
                int rows = array.GetLength(0);
                int сolumns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                  
                    for (int j = 0; j < columns; j++)
                    {
                 
                        array[i, j] = random.Next(0, 10);
                    }
                }

            }

  void PrintArray(int[,] array)
            {
                Console.WriteLine();
                Console.WriteLine("Вывод массива");
                int rows = array.GetLength(0);
                int сolumns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
    
}
Zadacha56();