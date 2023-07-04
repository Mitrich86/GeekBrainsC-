// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] matrix = InitMatrix(rows, columns);

Print(matrix);
System.Console.WriteLine("среднее арифметическое:");
PrintAverageAr(matrix);

//------------------------метод вывода среднего арифметического каждого столбца массива-----
void PrintAverageAr(int[,] arr)
{
    for (int l = 0; l < arr.GetLength(1); l++)
    {
        double summ = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            summ = summ + arr[i, l];
        }
        Console.Write($" |{summ / arr.GetLength(0):f1}|");
    }
}
//-------------------------------------------
//-------------------------------------------метод инициализации массива
int[,] InitMatrix(int rows, int columns)
{
    int[,] tmp = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            tmp[i, l] = random.Next(0, 10);
        }
    }
    return tmp;
}
//-------------------------------------------
//-------------------------------------------перемешивание чисел в матрице
void GetMatrix(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            arr[i, l] = random.Next(0, 10);
        }
    }
}
//-------------------------------------------
//-------------------------------------------вывод заданного массива
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            System.Console.Write($" |{arr[i, l]:f1}|");
        }
        Console.WriteLine();
    }
}
//-------------------------------------------




