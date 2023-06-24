// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int y = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= y; ++i)
{
     result = result * x;
}
Console.Write(result);