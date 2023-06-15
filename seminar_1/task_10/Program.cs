// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число: {number}");

int result = (number - (number - number % 100))/10;

Console.WriteLine($"Вторая цифра: {result}");
