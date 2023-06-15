// Задача №14.Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число ");
int num1 = int.Parse(Console.ReadLine());

if (num1 % 7 == 0)
{
    if (num1 % 23 ==0)
    {
        Console.Write("Кратно");
    }
    else
    {
        Console.Write("НеКратно");
    }
}
else
{
     Console.Write("НеКратно");
}