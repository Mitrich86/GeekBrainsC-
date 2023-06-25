// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[9];
int even_numbers = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($" |{array[i]}|");
    double num = array[i] % 2;
    if (num == 0)
    {
        even_numbers++;
    }
}
Console.Write($" количество четных чисел = {even_numbers}");


