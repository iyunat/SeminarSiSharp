// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Hello, World!");
Console.Write("Введите число: ");

int Num = Convert.ToInt32(Console.ReadLine());

int NumSum (int Num)
{
  int Sum = 0;
  while (Num > 0)
  {
    Sum = Sum + Num % 10;
    Num /=10;
  }
  return Sum;
}

int result = NumSum (Num);
Console.WriteLine("Сумма цифр в числе: " + result);