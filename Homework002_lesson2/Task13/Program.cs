//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5    78 -> третьей цифры нет  32679 -> 6

Console.WriteLine ( "Введите число");
int Num = Convert.ToInt32 (Console.ReadLine() );
string Number = Convert.ToString(Num);
if (Number.Length > 2)
{
  Console.WriteLine(Number[2]);
}
else {
  Console.WriteLine(" третьей цифры нет");
}