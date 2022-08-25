// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

// 1.Создаем массив:
int [] MasCreating (int n=3)
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
    int size = array.Length;
    for (int i = 0; i< size; i++)
    {
        array [i]= Random.Shared.Next ();// это тоже самое , если написать array [i]= new Random().Next ()
    }
 }
 
// 4.Находим сумму элементов, стоящих на нечётных позициях

int SumNoEven(int []array)
{
    int size = array.Length;
    int sumnoeven = 0;
    for (int i = 0; i < size; i++)
    {
       if (i % 2 ! == 0)
       {
        sumnoeven = sumnoeven + array [i];
       }   
    }
    return sumnoeven;
 }

int [] arr = MasCreating (3);// задаем массив. Если значение в () убрать, то создаваться массив будет n=11 (стр.5)
 RandMass (arr);
int values =SumNoEven (arr);
 Console.WriteLine ($"value: {ArrayTuString (arr)}");
 Console.WriteLine (values);
