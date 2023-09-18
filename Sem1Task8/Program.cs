//Задача 8:
//Написать программу, которая принимает число N и
//выдает все четные от 1 до N

Console.Write("Введите число: ");
//Считываем данные с консоли
int num=int.Parse(Console.ReadLine()??"0");
//Создание счетчика
int count=0;
// Проверка на четность
if (num % 2 == 0)
{
}
else
{
//Приведение к четности
    num = num-1;
}
//Увеличение счетчика
while (count<num)
{
    count=count+2;
Console.Write(count+", ");
}