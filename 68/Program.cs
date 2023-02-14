// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите 1 натуральное число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 натуральное число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------------");
if (m < 0 || n < 0) Console.WriteLine("Введены некорректные данные");
int result = AkkermanMethod(m, n);
Console.Write($"m={m}, n={n}  ->  функция Аккермана = ");
Console.WriteLine($"{result}");


int AkkermanMethod(int n, int m)
{
    if (n == 0) return m + 1;                        //условие выхода из рекурсии
    if ((n != 0) && (m == 0)) return AkkermanMethod(n - 1, 1);
    else return AkkermanMethod(n - 1, AkkermanMethod(n, m - 1));
}


