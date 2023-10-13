// Написать программу, которая принимает число А и выдает сумму
//чисел от 1 до А

//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//Вычисляем сумму
int SimpleSum(int numA)
{
    int sumOfNumber=0;
    for (int i=0; i<=numA; i++)
    {
        //sumOfNumber=sumOfNumber+i;
        sumOfNumber+=i;
    }
    return sumOfNumber;
}

int GaussSum(int numA)
{
    int sumOfNumber=0;
    sumOfNumber=(numA*(numA+1))/2;
    return sumOfNumber;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numA = ReadData("Введите число: ");
int res1=SimpleSum(numA);
int res2=GaussSum(numA);
PrintResult("Сумма чисел от 1 до "+numA+ " (простой) равна "+res1);
PrintResult("Сумма чисел от 1 до "+numA+ " (Гаусса)равна "+res2);