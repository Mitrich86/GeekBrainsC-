// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

//Создание рандомного массива вещественных чисел
double[] GetRandomArray(int size, double startValue, double endValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}
//Вывод массива
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" |{array[i]:F2}|");
    }
    // Console.WriteLine(string.Join(" ", array.Select(n => $"{n:F2}")));
}

double[] array = GetRandomArray(5, -9, 9);//генерация массива
PrintArray(array);//вывод сгенерированного массива вещественных чисел 

double max_number = array[0];
double min_number = array[0];
for (int i = 0; i < array.Length; i++)//цикл проходит по массиву и находит макс и мин
{
    if (array[i] > max_number)
    {
        max_number = array[i];
    }

    if (array[i] < min_number)
    {
        min_number = array[i];
    }
}
double raznica = max_number - min_number;
Console.Write($" Разница между {max_number:F2} и {min_number:F2} = {raznica:F2}");


