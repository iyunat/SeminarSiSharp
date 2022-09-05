// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка


//Создаем массив:

    int[,] array = new int[4, 4] { { 1, 2, 5, 2 }, { 6, 4, 8, 2 }, { 5, 6, 4, 3 }, {3, 1, 2, 1} };
    for (int i = 0; i < array.GetLength(0); i++)
    {
Console.Write("Строка "+ i+": ");
    for (int j=0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j]+" ");
    }
    Console.WriteLine(); 
    }

int minSumma = 0;
int summaLine = SummaElements(array, 0);

int SummaElements(int[,] array, int i)
{
    int summaLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
  {
    summaLine += array[i,j];
  }
  return summaLine;
  }

for (int i = 0; i < array.GetLength(0); i++)
{
  int tempSumma = SummaElements(array, i);
  if (summaLine > tempSumma)
  {
    summaLine = tempSumma;
    minSumma = i;
  }
  Console.WriteLine(tempSumma);
}


Console.WriteLine($"\n{minSumma} - строкa с наименьшей суммой элементов({summaLine})  ");