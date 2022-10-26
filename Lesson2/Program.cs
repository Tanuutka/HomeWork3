// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите  координаты первой точки: ");
int x1 = Convert.ToInt32 (Console.ReadLine());
int y1 = Convert.ToInt32 (Console.ReadLine());
int z1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите  координаты второй точки: ");
int x2 = Convert.ToInt32 (Console.ReadLine()); 
int y2 = Convert.ToInt32 (Console.ReadLine());
int z2 = Convert.ToInt32 (Console.ReadLine());

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1; 

double length = Math.Sqrt(x*x + y*y + z*z);
length = Math.Round (length,2);
Console.WriteLine("Длина равна: " + length);
