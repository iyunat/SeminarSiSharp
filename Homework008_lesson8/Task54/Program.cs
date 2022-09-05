// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


//Создаем массив:

    int[,] array = new int[3, 4] { { 1, 2, 5, 7 }, { 6, 4, 8, 2 }, { 5, 6, 4, 3 } };
    for (int i = 0; i < array.GetLength(0); i++)
    {
Console.Write("Строка "+ i+": ");
    for (int j=0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j]+" ");
    }
    Console.WriteLine(); 
    }


for (int i = 0; i < array.GetLength(0); i++)
{
      for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int y = 0; y < array.GetLength(1) - 1; y++)
            {
            if (array[i, y] < array[i, y + 1]) 
            {
                int temp = 0;
                temp = array[i, y];
                array[i, y] = array[i, y + 1];
                array[i, y + 1] = temp;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями по убыванию");

for (int i = 0; i < array.GetLength(0); i++)
    {
Console.Write("Строка "+ i+": ");
    for (int j=0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j]+" ");
    }
    Console.WriteLine(); 
    }


