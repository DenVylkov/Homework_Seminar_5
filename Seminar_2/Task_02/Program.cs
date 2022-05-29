Console.Clear();
Console.Write("Введите любое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberA = number % 100;
int numberB = numberA / 10;
Console.Write($"Ответ: вторая цифра числа {number} -> {numberB} ");
Console.WriteLine ();