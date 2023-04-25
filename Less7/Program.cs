/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// double [ , ] arr = new double [3, 4];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = Convert.ToDouble(new Random().Next(-10, 10))/10;
//         Console.Write($"{arr [i , j], -2} ");
//     }
//     Console.WriteLine();
// }

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

// int [,] myIntArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(-30, 30);
//         }
//     }
//     return array;
// }
// //Вывод массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
        
//             Console.WriteLine($"{array[i, j],3}");
//             Console.WriteLine();
//     }
// }
// //Проверка позиций значений и вывод результата
// void ChekingValuePos(int n, int m, int[,] array)
// {
//     if (n <= array.GetLength(0) && m <= array.GetLength(1))
//         Console.Write($"{array[n - 1, m - 1]}");
//     else
//         Console.Write($"{m} -> такого числа в массиве нет");
    
// }

// int [,] array = myIntArray(new Random().Next(3, 3), new Random().Next(3, 3));
// PrintArray(array);
// int n, m;
// Console.Write($"Введите позицию элемента (Строку): ");
// int.TryParse(Console.ReadLine()!, out n);
// Console.Write($"Ввведите позицию элемента (Столбца): ");
// int.TryParse(Console.ReadLine()!, out m);
// ChekingValuePos(n, m, array);

/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Console.Write($"Введите колличество строк: ");
// int n;
// int.TryParse(Console.ReadLine()!, out n);
// Console.Write($"Введите колличество столбцов: ");
// int m;
// int.TryParse(Console.ReadLine()!, out m);

// int[,] array = new int[n, m];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//         Console.Write($"{array[i, j], -2} ");
//     }
//     Console.WriteLine();
// }

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double avg = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         avg = (avg + array[i, j]);
//     }
//     avg /= n;
//     Console.Write(avg + "; ");
// }
