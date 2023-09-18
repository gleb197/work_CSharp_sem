//Задача 2:
//Написать программу, которая принимает два числа и
//выдает какое число болеше, какое меньше

Console.WriteLine("Введите первое число ");
//Считываем данные с консоли
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
//Считываем данные с консоли
int numB = int.Parse(Console.ReadLine());
//Проверяем 
if (numA<numB)
{
Console.WriteLine("Второе число больше первого");
Console.WriteLine("Первое число меньше второго");
}
else
{
Console.WriteLine("Первое число больше второго");
Console.WriteLine("Второе число меньше первого");
}