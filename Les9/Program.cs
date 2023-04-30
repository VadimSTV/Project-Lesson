/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int N;

Console.Write($"Задайте значение N: ");
int.TryParse(Console.ReadLine()!, out N);

string rec(int N)

{
    if (N == 1)
    {
        return $"{N}";
    }
    return $"{N}, {rec(N-1)}";
}
Console.Write (rec(N-1));
