// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System;
using static System.Console;

Clear();

WriteLine("Введите число a");
int number_a = Convert.ToInt32(ReadLine());

WriteLine("Введите число b");
int number_b = Convert.ToInt32(ReadLine());

WriteLine("Введите число c");
int number_c = Convert.ToInt32(ReadLine());

int result = number_a;

if (result < number_b)
{
   result = number_b;
}
if (result < number_c)
{
   result = number_c;
}
Write("max = ");
Write(result);