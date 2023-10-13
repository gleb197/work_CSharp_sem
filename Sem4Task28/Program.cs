// Написать программу, которая принимает число N
//и выдает произведение чисел от 1 до N

//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//Вычисляем сумму
long Factorial(int num)
{
    long res=1;
    for (int i=2; i<=num; i++)
    {
        res = res*i;
    }
    return res;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
long res=Factorial(num);
PrintResult("Произведение чисел от 1 до "+num+ " равна "+res);


