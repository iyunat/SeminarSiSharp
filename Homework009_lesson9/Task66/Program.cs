// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M={M}, N={N}");

if (N>M)
for (int i = M; i <= N; i++)
    Console.Write($" {i}");
else
    for (int i = N; i <= M; i++)
        Console.Write($" {i}");

Console.WriteLine();
PrintSum (M,N);

void PrintSum (int M, int N)
{
Console.WriteLine(SumNum(M-1, N));
}

int SumNum(int M, int N)
{
    int result = M;
    if (M==N)
        return 0;
    else
    {
    M++;
    result= M + SumNum (M, N);
    return result;
    }
}



