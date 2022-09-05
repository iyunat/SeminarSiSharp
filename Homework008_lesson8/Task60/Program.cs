// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int[,,] array = {
    {
        {11, 23, 13, 47},
        {59, 61, 17, 88}
    },
    {
        {44, 35, 12, 14},
        {10, 51, 71, 95}
    }
};

for (int i = 0; i < array.GetLength(0); i++)
    {
Console.Write("Массив №{0} \n", i);
    for (int j=0; j < array.GetLength(1); j++)
    {
    for (int z = 0; z < array.GetLength(2); z++)
    {
        Console.Write( $"[{i},{j},{z}] = {array[i,j,z]}; ");
            }
        Console.WriteLine(); 
    }
        Console.WriteLine();
    }
    

