// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// 1.Создаем массив:
int [] MasCreating (int n=4)
{
    return new int [n];
}

// 2. Выводим массив на экран:
 string ArrayTuString (int[] col)
 {
    return $"[{String.Join(' ', col)}]";
 }

 
 //3.Метод, который заполняет массив:
 void RandMass (int [] array, int min=1, int max = 100)
 {
    int size = array.Length;
    for (int i = 0; i< size; i++)
    {
        array [i]= Random.Shared.Next (min, max);// это тоже самое , если написать array [i]= new Random().Next (min, max)
    }
 }
int [] arr = MasCreating (4);// задаем массив. Если значение в () убрать, то создаваться массив будет n=11 (стр.5)
 RandMass (arr);
 Console.WriteLine($"value: {ArrayTuString (arr)}");
 
 //4. Разница между максимальным и минимальным значением

    int size = arr.Length;
    int max = arr[0];
    int min = arr[0];
        for (int i = 1; i <size; i++)
        {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
        }
        int differ = max - min;

        Console.WriteLine("Разность между максимальным и минимальным элементом массива = {0}", differ);


