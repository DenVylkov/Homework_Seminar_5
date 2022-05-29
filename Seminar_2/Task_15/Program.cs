/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber >= 1 && DayNumber <=5) 
{
    Console.Write($"{DayNumber} -> нет");
}
if (DayNumber >= 6 && DayNumber <= 7) 
{
    Console.Write($"{DayNumber} -> да");
}
if (DayNumber > 7)
{
  Console.Write("Цифра не является обозначающей день недели!");
}
Console.WriteLine();