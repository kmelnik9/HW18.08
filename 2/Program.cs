﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число A: ");

int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");

int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Максимальное число: {numberA}");
}
else
{
    Console.WriteLine($"Максимальное число: {numberB}");
}