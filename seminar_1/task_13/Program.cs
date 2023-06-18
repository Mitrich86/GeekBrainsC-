// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int number = new Random().Next(-2000000000, 2000000000);
//int number = -99;
Console.WriteLine($"Сгенерированное число: {number}");

if ((number < -99) || (number > 99))
{
    number = Math.Abs(number);
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.Write($"Третья цифра числа: {number} ");
}
else
    Console.Write($"В числе нет третьей цифры");


