//  Напишите метод, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// нельзя использовать pow


Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

int degree = A;

int NumDegree (int A, int B)
{
    for (int i = 1; i < B; i++)
{
degree = degree * A;
}
return degree;
}

int res = NumDegree (A, B);
Console.WriteLine ($"A в степени B равно {res}");
