// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
Console.Write($"{number} -> ");
for (int i = 1; i <= number; i++)
{
    result = i * i * i;
    Console.Write(result);
    if (i!=number)
    {
        Console.Write(" , ");
    }
}
Console.WriteLine();
Console.WriteLine();
