/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

// int N;

// Console.Write($"Задайте значение N: ");
// int.TryParse(Console.ReadLine()!, out N);

// string rec(int N)

// {
//     if (N == 1)
//     {
//         return $"{N}";
//     }
//     return $"{N}, {rec(N-1)}";
// }
// Console.Write (rec(N-1));

/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// int m, n;
// Console.Write($"Задайте значения M: ");
// int.TryParse(Console.ReadLine()!, out m);
// Console.Write($"Задайте значения N: ");
// int.TryParse(Console.ReadLine()!, out n);

// int rec (int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     else if (m > n)
//     {
//         return 0;
//     }
//     return m + rec(m + 1, n);
// }

// Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n}: {rec(m, n)}");


/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m, n;
Console.Write($"Введите неотрицательное число m: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите неотрицательное число n: ");
int.TryParse(Console.ReadLine(), out n);

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m != 0) && (n == 0))
    {
        return A(m - 1, 1);
    }
    else 
        return A(m - 1, A(m, n - 1));
}

Console.Write($"Функция Аккермана: {A(m, n)}");
