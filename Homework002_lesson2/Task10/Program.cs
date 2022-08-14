//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5     782 -> 8         918 -> 1

int Number (int arg)
{
    int result = (arg/10)%10;
    return result;
}

int [] array = {456, 782, 918};

int b = Number (array [0]);
Console.WriteLine (b);
int c = Number (array [1]);
Console.WriteLine (c);
int d = Number (array [2]);
Console.WriteLine (d);




