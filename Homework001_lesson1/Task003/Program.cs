double numberA = new Random ().Next (1, 10);
Console.WriteLine (numberA);
double numberC = numberA/2;
Console.WriteLine (numberC);
double numberD = (numberC*10) %10;
Console.WriteLine (numberD);
if (numberD ==0)
{
    Console.WriteLine ("Число четное");
}
else
{
    Console.WriteLine ("Число не четное");
}