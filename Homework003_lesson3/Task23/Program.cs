// Напишите метод, который принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

void NumCub (int[] Num)
{
  int count = 0;
  int length = Num.Length;
  while (count < length)
  {
    Num [count] = Convert.ToInt32(count * count *count);
    count++;
  }
}

void PrintArry(int[] arg)
{
  int coun = arg.Length;
  int index = 1;
  while(index < coun)
  {
    Console.Write(arg[index]+ " ");
    index++;
  }
} 

int[] arry = new int[Num+1];
NumCub (arry);
PrintArry(arry);