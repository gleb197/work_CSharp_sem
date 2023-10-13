// Задача 18:
//Напишите программу, которая по заданому номеру четверти показывает диапазон
//ввозможных координат точек в этой четверти (х,у)

//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int numQut = int.Parse(Console.ReadLine() ?? "0");
    return numQut;
}

//По номеру четверти определяем координаты
string QuterBorderAsk(int numQut)
{

   if (numQut == 1) return "x>0,y>0";
   if (numQut == 2) return "x>0,y<0";
   if (numQut == 3) return "x<0,y>0";
   if (numQut == 4) return "x<0,y<0";
   return string.Empty;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numQut = ReadData("Введите номер четверти: ");


PrintResult("Возможные координаты точки: "+QuterBorderAsk(numQut));