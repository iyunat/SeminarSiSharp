﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M={m}, N={n}");

int functionAkkerman = Ackerman(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ackerman (int m, int n)
{
  if (m == 0) 
  return n + 1;
  else if (n == 0) 
  return Ackerman(m - 1, 1);
  else return Ackerman(m - 1, Ackerman(m, n - 1));
}
