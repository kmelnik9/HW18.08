// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());

int A = number%2;

if (A == 0)
{
    Console.WriteLine("Да, число четное");
}
else
{
    Console.WriteLine("Нет, число не четное");
}