// написать программу, которая будет преобразовывать
//десятичное число в дваичное


//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

string DekToBin (int num)
{
    string line = "";
    while (num>0)
    {
        line = num%2 +line;
        num = num/2;
    }
    return line;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}



int num = ReadData("Введите число: ");

PrintResult($"Двоичное представление числа: {DekToBin (num)}");