/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.Write("Введите любое трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int SecondNumber = (Number % 100) / 10;
Console.Write($"Ответ: вторая цифра числа {Number} -> {SecondNumber} ");
Console.WriteLine ();
