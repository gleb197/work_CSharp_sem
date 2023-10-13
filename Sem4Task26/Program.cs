// Написать программу, которая принимает число и
//выдает количество цифр в числе

//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}


int NumDigits(int num)
{
    int count=0;
    while (num>0)
    {
        count++;
        num =num/10;
    }
    return count;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num=ReadData("Введите число ");
Console.WriteLine(NumDigits(num));
