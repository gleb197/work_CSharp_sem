﻿//Задача 6:
//Написать программу, которая принимает число и
//выдает является ли оно четным

Console.Write("Введите число: ");
//Считываем данные с консоли
int num = int.Parse(Console.ReadLine()??"0");
// Проверка на четность
if (num%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}