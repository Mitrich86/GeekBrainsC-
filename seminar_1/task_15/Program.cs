// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


int number = new Random().Next(1, 15);
Console.WriteLine($"Сгенерированное число: {number}");

switch (number)
{
    case 1:
        Console.WriteLine("День недели понедельник - работаем");
        break;
    case 2:
        Console.WriteLine("День недели вторник - работаем");
        break;
    case 3:
        Console.WriteLine("День недели среда - работаем");
        break;
    case 4:
        Console.WriteLine("День недели четверг - работаем");
        break;
    case 5:
        Console.WriteLine("День недели пятница - работаем по сокращенному");
        break;
    case 6:
        Console.WriteLine("День недели суббота - выходной");
        break;
    case 7:
        Console.WriteLine("День недели воскресенье - выходной");
        break;
    default:
        Console.WriteLine("такого дня не существует");
        break;
}