// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrixA = new int [2, 2];
int[,] matrixB = new int [2, 2];
int[,] matrixC = new int [2, 2];

void FillArray(int [,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
{
    matr[i,j]= new Random() .Next(1,10);
}
    }
}

void PrintArray(int[,] matr)
{
for(int i=0; i< matr. GetLength(0); i++)
{
    for(int j=0; j < matr. GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
            }
    Console.WriteLine();
}
Console.WriteLine();
}

FillArray(matrixA);
FillArray(matrixB);
Console.WriteLine("Матрица - А");
PrintArray (matrixA);
Console.WriteLine("Матрица - B");
PrintArray(matrixB);

for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int z = 0; z < matrixC.GetLength(1); z++)
    {
  for (int j = 0; j < matrixA.GetLength(1); j++)
  {
    matrixC[i, j] += matrixA[i, z] * matrixB[z, j];
  }
 }
}

Console.WriteLine("Произведение матриц А*В - матрица С");
PrintArray(matrixC);
