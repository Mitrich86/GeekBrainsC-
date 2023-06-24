// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num = Math.Abs(number);
int result = 0;
while (num > 0)
{
    result = result + (num % 10);
    num = num / 10;
}
Console.Write(result);

