Console.Clear();
Console.Write("Введите любое трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int SecondNumber = (Number % 100) / 10;
Console.Write($"Ответ: вторая цифра числа {Number} -> {SecondNumber} ");
Console.WriteLine ();
