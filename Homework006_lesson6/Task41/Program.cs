// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


// 1.Создаем массив:
int [] MasCreating (int n=7)
{
    return new int [n];
}

// 2. Выводим массив на экран:
 string ArrayTuString (int[] col)
 {
    return $"[{String.Join(' ', col)}]";
 }



//3.Метод, который заполняет массив:
 void RandMass (int [] array)
 {
    Console.Write($"Введите число М(количество чисел): ");
    int size = array.Length;
    for (int i = 0; i< size; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        array [i]= Convert.ToInt32(Console.ReadLine());
    }
 }


//4. Метод, который считает сколько чисел пользователь ввел выше 0

int QuantityNumPositiv (int [] array)
 {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > 0)
        {
            count++;
        }
    }
    return count;
 }

int [] arr = MasCreating (7);
Console.WriteLine ($"value: {ArrayTuString (arr)}");

RandMass (arr);

int count = QuantityNumPositiv (arr);
Console.WriteLine ($"Количество  чисел выше 0: {count}");