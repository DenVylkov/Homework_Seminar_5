Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    Console.Write("");
    if (i % 2 == 0)
    {
    Console.Write(i);
    Console.Write(", ");
    }
}