// Напишите программу, которая принимает два чила и выводит кратно ли второе 
//число первому. Если чило не кратно, то выводит остаток от деления

Console.Write("Введите число ");
int numA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите число ");
int numB = int.Parse(Console.ReadLine()??"0");
if (numB % numA == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому, остаток от деления "+(numB % numA));
}
