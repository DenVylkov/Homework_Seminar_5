// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int sum = 0;
for (int i = 0; i <= number; i++)
{
    count = number - number % 10;
    sum = sum + (number - count);
    number = number / 10;
}
Console.WriteLine($"Сумма цифр в числе равна: {sum}");
