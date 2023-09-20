//Напишите программу, которая принимает на вход два числа и проверяет
//является ли первое число квадратом второго

Console.Write("Введите число ");
int numA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите число ");
int numB = int.Parse(Console.ReadLine()??"0");

bool test1 = (numA == numB * numB);
bool test2 = (numB == numA * numA);

if (test1)
{
    Console.WriteLine("Первое число квадрат второго");
}
if (test2) 
{
    Console.WriteLine("Второе число квадрат первого");
}
if (!(test1 || test2))
{
    Console.WriteLine("Числа не квадраты друг друга");
}



