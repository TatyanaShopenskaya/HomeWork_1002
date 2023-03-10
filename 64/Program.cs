// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------------------");
Console.Write($"N = {number}   ->   ");

NaturalNumbers(number);        //вызываем метод рекурсии

void NaturalNumbers(int num)   //задаем рекурсивную функцию 
{
    if (num==0) return;        //условие выхода из РЕКУРСИИ      
    Console.Write($"{num}");
    if (num>1) Console.Write(",   ");
    if (num<1) Console.Write("Введены некорректные данные");
}
