// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.



// Метод заполнения случайными числами

void FillArray(double [,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
{
    matr[i,j]= new Random() .NextDouble()*100;
}
    }
}

//Метод вывода матрицы на печать

void PrintArray(double[,] matr)
{
for(int i=0; i< matr. GetLength(0); i++)
{
    for(int j=0; j < matr. GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
    Console.WriteLine();
}
}

double[,] matrix = new double [3,4];
Console.WriteLine(); 
FillArray(matrix);
PrintArray(matrix);

