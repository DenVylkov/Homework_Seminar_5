Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > max) max = numberB;
Console.WriteLine("Ответ: ");
Console.WriteLine(max);