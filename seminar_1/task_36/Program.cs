// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[5];
int odd_numbers = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($" |{array[i]}|");
    double num = i % 2;
    if (num != 0)
    {
        odd_numbers = odd_numbers+array[i];
    }
}
Console.Write($" сумма элементов, стоящих на нечетных позициях = {odd_numbers}");



