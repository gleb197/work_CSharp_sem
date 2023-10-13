// Написать программу, которая принимает число 
//и выдает сумму чисел в числе

//прием данных
int ReadData(string smg)
{
    Console.WriteLine(smg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

int SunDigit (int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num%10;
        num =num/10;
    }
     return res;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.Write(msg);
}


int num = ReadData("Введите число: ");
int res = SunDigit (num);
PrintResult("Сумма чисел в числе "+num+" равна "+res);