// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите координату Х: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine());

if (X == 0 || Y == 0)
{
    Console.Write("не допустимые координаты Х и Y !=0 ");
}
if (X > 0 && Y > 0)
{
    Console.Write("номер четверти 1 ");
}
if (X < 0 && Y > 0)
{
    Console.Write("номер четверти 2 ");
}
if (X < 0 && Y < 0)
{
    Console.Write("номер четверти 3 ");
}
if (X > 0 && Y < 0)
{
    Console.Write("номер четверти 4 ");
}

