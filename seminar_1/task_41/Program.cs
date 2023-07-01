// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Enter numbers: ");
int M = Convert.ToInt32(Console.ReadLine());

int positive = 0;
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter num {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());    //new Random().Next(-100, 100);
    if (array[i] > 0)
    {
        positive++;
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($" |{array[i]}|");
}
Console.Write($" Количество положительных чисел -> {positive} ");


