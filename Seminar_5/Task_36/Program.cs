//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50, 50);
    }
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {

            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int SumOfNumber(int[] array) 
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i ++) 
    { 
        if (i % 2 != 0) 
        { 
           count = count + array[i];
        } 
    } 
  return count;
} 
 
int[] array = new int[5]; 
FillArray(array); 
int count = SumOfNumber(array); 
PrintArray(array); 
Console.WriteLine($" -> {count}");