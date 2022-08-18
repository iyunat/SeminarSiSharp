// Напишите метод, который принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84  A (7,-5, 0); B (1,-1,9) -> 11.53

int PositionInput (string pos, string cur)
{   Console.Write($"Введите координату {pos} точки {cur}: ");
    return Convert.ToInt16(Console.ReadLine());
}
int ax = PositionInput ("x", "A");
int ay = PositionInput ("y", "A");
int az = PositionInput ("z", "A");
int bx = PositionInput ("x", "B");
int by = PositionInput ("y", "B");
int bz = PositionInput ("z", "B");

double Distance (double ax, double bx, double ay, double by, double az, double bz )
{
    return Math.Sqrt (((ax - bx)* (ax -bx)) + ((ay -by) * (ay -by)) + ((az -bz) *(az - bz)));
}

double resultDistance = Distance (ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние  {resultDistance}");