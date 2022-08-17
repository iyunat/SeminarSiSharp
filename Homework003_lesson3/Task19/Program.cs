// Напишите метод, который принимает на вход шестизначное число и
 //проверяет, является ли оно палиндромом.

//Console.WriteLine ( "Введите шестизначное число");
//int Num = Convert.ToInt32 (Console.ReadLine() );
//string Number = Convert.ToString(Num);

Console.WriteLine ( "Введите число");
int Num = Convert.ToInt32 (Console.ReadLine() );
string Number = Convert.ToString(Num);

int arg;
int NewNum = 0;
int div = 0;

int Palindrome (int arg)
{ 
    for (arg = Num; arg > 0; arg= (arg/10))
    {
      div = arg % 10;
      NewNum = NewNum * 10 + div;
    } 
    return NewNum; 
}

int res = Palindrome (Num);
if (NewNum == Num)
{
    Console.WriteLine ("Число {0} является палиндромом", Num);
}
else
{
   Console.WriteLine ("Число не является палиндромом"); 
}
   
Console.WriteLine (res);