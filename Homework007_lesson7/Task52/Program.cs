// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


// //Нахождение среднего арифметического элементов столбца

int summa =0;
int [,] matrix = new int [5,6];



 for (int i = 0; i < matrix. GetLength(0); i++)
 double arithmeticSumma = 0;
 {
    for (int j = 0; j < matrix. GetLength(1); j++)
    {
  summa += matrix[i, j]; 
    } 
  arithmeticSumma = Math.Round(arithmeticSumma / 6, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticSumma}");
}
 
  void ArrayInt (int[,] matrix)
{
for (int i = 0; i <matrix. GetLength(0); i++)
  {
      for (int j = 0; j < matrix. GetLength(1); j++)
      {
        Console.Write(matrix[i, j] + " ");
      }
      Console.WriteLine();
  }
}

 ArrayInt (matrix);

