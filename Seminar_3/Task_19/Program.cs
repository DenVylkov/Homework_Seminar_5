// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.Clear();
Console.Write("Введите любое пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int FirstNumber = Number / 10000;
int SecondNumber = Number / 1000 % 10;
int FourthNumber = Number % 100 / 10;
int FifthNumber = Number % 10;

if (Number <= 9999 || Number > 99999)
{
    Console.WriteLine($"Число {Number} -> не является пятизначным");
}
else if (FirstNumber == FifthNumber && SecondNumber == FourthNumber)
{
    Console.WriteLine($"{Number} -> да");
}
else
{
    Console.WriteLine($"{Number} -> нет");
}
