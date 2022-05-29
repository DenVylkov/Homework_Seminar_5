/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 ->
*/


Console.Clear();
Console.ForegroundColor=ConsoleColor.White;
Console.Write("Введите любое положительное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
 Console.ForegroundColor=ConsoleColor.Red;
if (Number <= 99)
{
    Console.WriteLine($"В числе {Number} -> третьей цифры нет!");
}
    
else
{   Console.ForegroundColor=ConsoleColor.White;
    if (Number > 99 & Number <= 999)
    {
        int NumberThree = (Number % 10);
        Console.WriteLine($"{Number} -> {NumberThree}");
    }
    if (Number > 999 && Number <= 9999)
    {
        int NumberThree = ((Number % 100) / 10);
        Console.WriteLine($"{Number} -> {NumberThree}");
    }
    if (Number > 9999 & Number <= 99999)
    {
        int NumberThree = ((Number % 1000) / 100);
        Console.WriteLine($"{Number} -> {NumberThree}");
    }
    if (Number > 99999 & Number <= 999999)
    {
        int NumberThree = ((Number % 10000) / 1000);
        Console.WriteLine($"{Number} -> {NumberThree}");
    }
    Console.WriteLine("__________________________");
}
