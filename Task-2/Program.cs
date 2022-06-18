// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

using System;
using static System.Console;

Clear();

WriteLine("Введите число a");
int number_a = Convert.ToInt32(ReadLine());

WriteLine("Введите число b");
int number_b = Convert.ToInt32(ReadLine());

if (number_a > number_b)
{
   Write("max = ");
   Write(number_a);
}
else
{
   Write("max = ");
   Write(number_b);
}