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

Console.Write($"Введите кол-во строк: ");
int a;
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите кол-во столбцов: ");
int b;
int.TryParse(Console.ReadLine()!, out b);

int[,] arr = new int [a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        arr[i, j] = new Random().Next(1, 10);
        Console.Write($"{arr[i,j], -2}");
    }
    Console.WriteLine();
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            if (arr[i,k] < arr[i, k + 1])
            {
                int temp = arr[i, k + 1];
                arr[i, k + 1] = arr[i, k];
                arr[i, k] = temp;
            }
        }
    }
    Console.WriteLine();
}

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j], -2} ");
    }
    Console.WriteLine();
}