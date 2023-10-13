// написать программу, которая принимает два числа и
//возводит число А в натуральную степень В

//прием данных
int ReadData(string smg)
{
    Console.WriteLine(smg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//расчет результата
long MyPow (int numA, int numB)
{
     long res = 1;
     while (numB>0)
     {
        res = res * numA;
        numB = numB - 1;
     }
     return res;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.Write(msg);
}

int numA = ReadData("Введите число А: ");
int numB = ReadData("Введите число В: ");
long res = MyPow (numA, numB);
PrintResult("Число "+numA+" в степени "+numB+" равно "+res);