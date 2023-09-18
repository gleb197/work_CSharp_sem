//Задача 1:
//Является ли 1-е число квадратом 2-го

Console.WriteLine("Введите первое число ");
int numA = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число ");
int numB = int.Parse(Console.ReadLine()??"0");
if (numB*numB==numA)
{
Console.WriteLine("Первое число квадрат второго");
}
else
{
Console.WriteLine("Первое число не квадрат второго");
}