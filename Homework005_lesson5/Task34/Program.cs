// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// 1.Создаем массив:
int [] MasCreating (int n=11)
{
    return new int [n];
}

// 2. Выводим массив на экран:
 string ArrayTuString (int[] col)
 {
    return $"[{String.Join(' ', col)}]";
 }

 

 //3.Метод, который заполняет массив:
 void RandMass (int [] array, int min=100, int max = 1000)
 {
    int size = array.Length;
    for (int i = 0; i< size; i++)
    {
        array [i]= Random.Shared.Next (min, max);// это тоже самое , если написать array [i]= new Random().Next (min, max)
    }
 }
 
 

 //4. Программа, которая показывает количество четных чисел в массиве
 
 int QuantityNumEven (int [] array)
 {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
 }
 int [] arr = MasCreating (11);// задаем массив. Если значение в () убрать, то создаваться массив будет n=11 (стр.5)
 RandMass (arr);
 Console.WriteLine($"value: {ArrayTuString (arr)}");

 int count = QuantityNumEven (arr);
 Console.WriteLine ($"Количество четных чисел в массиве: {count}");