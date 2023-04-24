/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// Console.WriteLine("Введите размер массива");
// int size = int.Parse(Console.ReadLine()!);
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

//  void FillArrayRandomNumbers(int[] numbers)
//  {
//      for(int i = 0; i < numbers.Length; i++)
//      {
//          numbers[i] = new Random().Next(100,1000);
//      }
//  }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// Console.Write("Введите количество элементов массива: ");
// int a = int.Parse(Console.ReadLine()!);
// int[] randomArray = new int[a];

// void mas(int a)
// {
// for (int i = 0; i < a; i++)
// {
// randomArray[i] = new Random().Next(1,9);
// Console.Write(randomArray[i] + " ");
// }

// }

// int kol(int[] randomArray)
// {
// int sum = 0;
// int i = 0;
// while (i < randomArray.Length)
// {
// sum += randomArray[i];
// i += 2;
// }
// return sum;
// }

// mas(a);
// Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");