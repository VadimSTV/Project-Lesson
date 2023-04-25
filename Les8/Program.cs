/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// Console.Write($"Введите кол-во строк: ");
// int a;
// int.TryParse(Console.ReadLine()!, out a);
// Console.Write($"Введите кол-во столбцов: ");
// int b;
// int.TryParse(Console.ReadLine()!, out b);

// int[,] arr = new int [a, b];
// for (int i = 0; i < a; i++)
// {
//     for (int j = 0; j < b; j++)
//     {
//         arr[i, j] = new Random().Next(1, 10);
//         Console.Write($"{arr[i,j], -2}");
//     }
//     Console.WriteLine();
// }

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         for (int k = 0; k < arr.GetLength(1) - 1; k++)
//         {
//             if (arr[i,k] < arr[i, k + 1])
//             {
//                 int temp = arr[i, k + 1];
//                 arr[i, k + 1] = arr[i, k];
//                 arr[i, k] = temp;
//             }
//         }
//     }
//     Console.WriteLine();
// }

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write($"{arr[i, j], -2} ");
//     }
//     Console.WriteLine();
// }

/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// int [,] arr = new int[4, 4];
// int sum = 0;
// int minsum = 0;
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(0, 100);
//         Console.Write($"{arr[i, j], 3}");
//     }
//     Console.WriteLine();
// }

// for (int j = 0; j < arr.GetLength(1); j++)
// {
//     sum = sum + arr[0, j];
// }

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     int current = 0;
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         current = current + arr[i, j];
//     }
//     if (current < sum)
//     {
//         sum = current;
//         minsum = i + 1;
//     }
// }
// Console.Write($"номер строки с наименьшей суммой элементов: {minsum} строка");

/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// Console.Write($"Задайте две матрицы(размер): ");
// int M;
// int.TryParse(Console.ReadLine()!, out M);

// int [,] Firstmatrx = new int[M, M];
// int [,] Secmatrx = new int[M, M];
// Console.WriteLine($"Первая матрица: ");
// for (int i = 0; i < M; i++)
// {
//     for (int j = 0; j < M; j++)
//     {
//         Firstmatrx[i, j] = new Random().Next(1, 10);
//         Console.Write($"{Firstmatrx[i, j], -2} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine($"Вторая матрица: ");
// for (int i = 0; i < M; i++)
// {
//     for (int j = 0; j < M; j++)
//     {
//         Secmatrx[i, j] = new Random().Next(1, 10);
//         Console.Write($"{Secmatrx[i, j], -2} ");
//     }
//     Console.WriteLine();
// }

// int[,] Result = new int[M, M];
// for (int i = 0; i < M; i++)
// {
//     for (int j = 0; j < M; j++)
//     {
//         for (int k = 0; k < M; k++)
//         {
//             Result[i, j] = Result[i, j] + (Firstmatrx[i, k] * Secmatrx[k, j]);
//         }
//     }
// }
// Console.WriteLine($"Результирующая матрица будет: ");
// for (int i = 0; i < Result.GetLength(0); i++)
// {
//     for (int j = 0; j < Result.GetLength(1); j++)
//     {
//         Console.Write($"{Result[i, j], -2} ");
//     }
//     Console.WriteLine();
// }