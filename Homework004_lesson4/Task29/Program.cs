// Напишите метод, который задаёт массив из 
//8 элементов (диапазон от 1 до 100) и выводит их на экран.

void MassivRandom (string [] arg)
{
    int[] array = new int[8];
    array [0] = new Random(). Next(1,101);
    Console.WriteLine(array [0]);
    array [1] = new Random(). Next(1,101);
    Console.WriteLine(array [1]);
    array [2] = new Random(). Next(1,101);
    Console.WriteLine(array [2]);
    array [3] = new Random(). Next(1,101);
    Console.WriteLine(array [3]);
    array [4] = new Random(). Next(1,101);
    Console.WriteLine(array [4]);
    array [5] = new Random(). Next(1,101);
    Console.WriteLine(array [5]);
    array [6] = new Random(). Next(1,101);
    Console.WriteLine(array [6]);
    array [7] = new Random(). Next(1,101);
    Console.WriteLine(array [7]);
    
    for (int i=0; i < 100; i++ )
{
    Random rnd = new Random ();
    Console.WriteLine ($"{array[i]}");
}
    
}
int result = MassivRandom ("{0,8}", rnd. Next(1,101) (1,101));
Console.WriteLine (result);