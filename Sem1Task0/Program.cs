//Задоча 0
//Напишите программу, которая на вход принимает число и
//выдает его квадрат (число умноженое само на себя)

Console.WriteLine("Введите число ");
//Считываем данные с консоли
string? inputNum = Console.ReadLine(); //??"0"
//Проверяем, чтобы данные были не пустыми
if (inputNum!=null);
{
//Парсим введенное число
//int num = int.Parse(inputNum);
//Находим квадрат чила
//int res = num*num;
//Выводим данные в консоль
//Console.WriteLine(res);

Console.WriteLine("квадрат числа = " +(int)Math.Pow(int.Parse(inputNum),2));
}