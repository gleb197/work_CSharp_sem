//Задача 4:
//Написать программу, которая принимает три числа и
//выдает максимальное

Console.WriteLine("Введите первое число ");
//Считываем данные с консоли
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
//Считываем данные с консоли
int numB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третие число ");
//Считываем данные с консоли
int numC = int.Parse(Console.ReadLine());
int max = numA;
//Проверяем 
if (max<numB)
{
max=numB;
}
if (max<numC)
{
max=numC;
}
Console.WriteLine(max);