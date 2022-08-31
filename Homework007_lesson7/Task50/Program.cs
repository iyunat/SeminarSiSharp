// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 //и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] matr = new int [3,4];
int n = 3; // размер массива
int m = 4; // размер массива
void FindElement (int [,] arg)
{
    Console.Write("Введите строку:");
    int position1 = Convert.ToInt32(Console.ReadLine()) -1;
    Console.Write("Введите столбец:");
    int position2 = Convert.ToInt32(Console.ReadLine()) -1;
    
    Random random = new Random();
    int[,] matr = new int[n, m];
    Console.WriteLine("Матрица");

    for (int i=0; i<matr.GetLength(0); i++)
    {
    for (int j=0; j<matr.GetLength(1); j++)
 {
    matr[i,j]= random .Next(1, 10);
    Console.Write("{0} ", matr[i, j]);
 }
    Console.WriteLine();
    }
if (position1 < 0 | position1 > matr.GetLength(0) -1 | position2 < 0 | position2 > matr.GetLength(1) -1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
Console.WriteLine("Значение элемента массива = {0}", matr[position1, position2]);
}
Console.ReadLine();
}

FindElement (matr);
