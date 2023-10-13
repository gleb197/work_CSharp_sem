// задача 22:
//Написать программу, которая принимает число (N)и выдает
//таблицу квадратов чисел от 1-го до N

//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//Нахождение результата
string BuildLine(int num, int pow)
{
    string res = String.Empty;
    for (int i = 1; i <= num; i++)
    {
       res = res + Math.Pow(i,pow)+ " ";
    }
    return res;
}

//Печать резльтата
void PrintResult(string res)
{
    Console.WriteLine(res);
}

int num = ReadData("Введите число: ");
PrintResult(BuildLine(num, 1));
PrintResult(BuildLine(num, 2));