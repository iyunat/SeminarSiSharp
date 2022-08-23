// Напишите метод, который задаёт массив из 
//8 элементов (диапазон от 1 до 100) и выводит их на экран.

int [] mass = new int [8];
void ArrayRan (int [] array, int min, int max)
{
        for (int i=0; i < 8; i++)
    {
        array [i] = new Random(). Next(min, max);
    }
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
}
    
ArrayRan (mass, 1, 101);