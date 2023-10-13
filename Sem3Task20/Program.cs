// Задача 20:
//Написать программу, которая принимает координаты двух точек
// и находит растояние между ними в 2D пространстве

//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//Нахождение результата
double Calc2dDist(int x, int y)
{
    double res = Math.Sqrt(x*x+y*y);
    return res;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Введите координату х1: ");
int y1 = ReadData("Введите координату у1: ");
int x2 = ReadData("Введите координату х2: ");
int y2 = ReadData("Введите координату у2: ");
double res = Calc2dDist((x1-x2),(y1-y2));
PrintResult("Растояние равно " +$"{res}");