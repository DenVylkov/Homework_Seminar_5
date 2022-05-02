Console.Write("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max) max = numberB;
Console.Write("Ответ: ");
Console.WriteLine(max);