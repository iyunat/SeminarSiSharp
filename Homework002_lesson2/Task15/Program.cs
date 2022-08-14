//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да    7 -> да      1 -> нет


Console.WriteLine ( "Введите число от 1 до 7");
int DataNum = Convert.ToInt32 (Console.ReadLine() );

if (DataNum ==6 || DataNum ==7)
{
    Console.WriteLine ( "да, выходной день");
}
else
{
    Console.WriteLine ( "нет, это не выходной день");
}




