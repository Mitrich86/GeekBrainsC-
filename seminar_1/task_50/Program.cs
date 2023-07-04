// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

double[,] matrix = InitMatrix(rows, columns);

PrintArr(matrix);

Console.Write("Введите номер строки: ");
int findRow = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер стобца: ");
int findColumn = Convert.ToInt32(Console.ReadLine());

if ((findRow > rows) || (findColumn > columns))
{
    System.Console.WriteLine("Такого числа в матрице нет!");
}
else
{
    PrintNumber(matrix);
}


double[,] InitMatrix(int rows, int columns)
{
    double[,] tmp = new double[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            tmp[i, l] = random.Next(-10, 10) + random.NextDouble();
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
            arr[i, l] = random.Next(-10, 10) + random.NextDouble();
        }
    }
}

void PrintArr(double[,] arr)
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

void PrintNumber(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            if ((i == findRow - 1) & (l == findColumn - 1))
            {
                System.Console.Write($" |{arr[i, l]:f1}|");
            }
        }
    }
}







