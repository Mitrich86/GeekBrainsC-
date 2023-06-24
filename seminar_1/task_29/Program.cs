// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write($" |{array[i]}|");
}





//Задача на звездочку вывести двумерный массив:

// int[,] array = new int[4,4];
// for (int y = 0; y < array.GetUpperBound; y++)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i, y] = new {Random().Next(-10, 10),Random().Next(-10, 10)};
//         Console.Write($" |{array[i, y]}|");
//     }
//     Console.WriteLine();
// }
