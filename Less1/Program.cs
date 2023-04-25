     ////// Внимание \\\\\\       
//!!!Снимайте коментарий /**/ по одному с каждой задачи и производите запуск программы!!!!

/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int max = 0;
int min = 0;

int num1 = 0;
int num2 = 0;

Console.Write($"Введите первое число: ");
string text1 = Console.ReadLine()!;
num1 = int.Parse(text1);
Console.Write($"Введите второе число: ");
string text2 = Console.ReadLine()!;
num2 = int.Parse(text2);
    if (num1 > num2)
    {
        max = num1;
        min = num2;
    }
    
    else
    {
        max = num2;
        min = num1;
    }
    Console.Write("max = " + max + " и " + "min = " + min);

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
int max = 0;

int numFirst = 0;
int numSecond = 0;
int numThird = 0;

Console.Write($"Введите первое число: ");
string textFirst = Console.ReadLine()!;
numFirst = int.Parse(textFirst);

Console.Write($"Введите второе число: ");
string textSecond = Console.ReadLine()!;
numSecond = int.Parse(textSecond);

Console.Write($"Введите третье число: ");
string textThird = Console.ReadLine()!;
numThird = int.Parse(textThird);
    if (numFirst > max)
    {
        max = numFirst;
    }
    
    if (numSecond > max)
    {
        max = numSecond;
    }

    if (numThird > max)
    {
        max = numThird;
    }
    Console.Write("max = " + max);
    */

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
/*
int a;
Console.Write($"Введите число:");
int.TryParse(Console.ReadLine()!, out a);
    if (a % 2 == 0)
    Console.Write($"Число четное и делится на 2");
    else
    Console.Write($"Не делится на 2, остаток {a % 2}");
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
int n;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out n);

for (int i = 2; i <= n; i += 2)
{
    if (i % 2 == 0)
    Console.Write($"{i} ");
}
*/