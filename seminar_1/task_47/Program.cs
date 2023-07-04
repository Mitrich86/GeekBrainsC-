// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

double[,] matrix = InitMatrix(rows, columns);

Print(matrix);

double[,] InitMatrix(int rows, int columns)
{
    double[,] tmp = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            tmp[i, l] = random.Next(-10,10) + random.NextDouble();
        }
    }
    return tmp;
}

void GetMatrix(double[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            arr[i, l] = random.Next(-10,10) + random.NextDouble();
        }
    }
}

void Print(double[,] arr)
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


