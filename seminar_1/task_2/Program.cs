﻿// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine($"число {a} больше числа {b}");
}
else if (a < b)
{
    Console.WriteLine($"Число {a} меньше числа {b}");
}
else
{
    Console.WriteLine($"Число {a} равно числу {b}");
}
