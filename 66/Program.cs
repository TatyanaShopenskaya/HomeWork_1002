// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите 1 натуральное число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 натуральное число");
int num2 = Convert.ToInt32(Console.ReadLine());

SumNaturalNumbers(num1, num2);                             //вызываем метод рекурсии
int result = SumNaturalNumbers(num1, num2);
Console.WriteLine("-------------------------");
Console.Write($"M={num1}; N={num2}  ->  ");
Console.WriteLine(result);


int SumNaturalNumbers(int num1, int num2, int sum = 0)     //задаем рекурсивную функцию 
{
    if (num1 == num2) return sum = sum + num1;             //условие выхода из РЕКУРСИИ  
    else
    {
        sum = sum + num1;                                  //вычисление суммы
    }
    return SumNaturalNumbers(++num1, num2, sum);           //++num1 увеличивает значение num1, а затем возвращает его.
}
