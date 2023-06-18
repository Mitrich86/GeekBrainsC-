// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

static bool IsPalindrom(string word, bool ignoreCase = true)
{
    if (ignoreCase)
    {
        word = word.ToLowerInvariant();
    }

    for (int first = 0, last = word.Length - 1; first < last; ++first, --last)
    {
        if (word[first] != word[last])
        {
            return false;
        }
    }

    return true;
}

Console.Write("Введите положительное пятизначное число: ");
string number = Console.ReadLine();
int number2 = int.Parse(number);
if ((number2 > 9999) && (number2 < 100000))
{
    if (IsPalindrom(number) == true)
        {
            Console.Write($"Число {number} является палиндромом");
        }
    else 
    Console.Write($"Число {number} НЕ является палиндромом");
}
else
    Console.Write($"Введеное число не является пятизначным или положительным -> {number2}");
