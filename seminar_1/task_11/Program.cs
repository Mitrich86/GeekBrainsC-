// Задача №11. Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число: {number}");

int result = ((number - number % 100) / 10 + number % 10);
Console.WriteLine($"Исходное число: {result}");
