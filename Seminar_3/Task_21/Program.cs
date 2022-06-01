// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х точки А: ");
int XpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int YpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
int ZpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B: ");
int XpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int YpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
int ZpointB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((XpointA - XpointB) * (XpointA - XpointB) + (YpointA - YpointB) * (YpointA - YpointB) + (ZpointA - ZpointB) * (ZpointA - ZpointB));

Console.WriteLine("Расстояние между точками А и В равняется: " + Math.Round(result, 2));
Console.WriteLine();
