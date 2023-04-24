//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*int N;
Console.Write($"Введите 5-ти значное число: ");
int.TryParse(Console.ReadLine()!, out N);

if ((N / 1000 % 10 * 10 + N / 10000) == N % 100)
    Console.Write($"Число {N} является палиндромом");
else
Console.Write($"Число {N} ни фига не палиндром!");*/

/*
Задача 21. Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*int x1, x2, y1, y2, z1, z2;
double d;
Console.Write("Введите координату х1 первой точки: ");
int.TryParse(Console.ReadLine()!, out x1);
Console.Write("Введите координату y1 второй точки: ");
int.TryParse(Console.ReadLine()!, out y1);
Console.Write("Введите координату z1 третьей точки: ");
int.TryParse(Console.ReadLine()!, out z1);
Console.Write("Введите координату х2 первой точки: ");
int.TryParse(Console.ReadLine()!, out x2);
Console.Write("Введите координату y2 второй точки: ");
int.TryParse(Console.ReadLine()!, out y2);
Console.Write("Введите координату z3 третьей точки: ");
int.TryParse(Console.ReadLine()!, out z2);

double x = (x2 - x1) * (x2 - x1);
double y = (y2 - y1) * (y2 - y1);
double z = (z2 - z1) * (z2 - z1);
d = Math.Sqrt(x + y + z);
Console.Write($"{d}");*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125 


/*int n;
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out n);

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i * i * i} ");
}*/