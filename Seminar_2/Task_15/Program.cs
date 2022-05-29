/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber >= 1 && DayNumber < 6) 
{
    Console.Write($"{DayNumber} -> нет");
}
else
{
    Console.Write($"{DayNumber} -> да");
}
Console.WriteLine();