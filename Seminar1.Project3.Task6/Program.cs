﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
Console.WriteLine("Введете целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}