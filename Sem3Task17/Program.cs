//Задача 17:
//Напишите программу, которая принимает координаты точки (причем х , у
//не равно 0 и выдает номер четверти плоскости в которой находится эта точка

// Ввести х
// Ввести у
// Поиск ответа
// Вывести результат

//Ввод данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//По координатам определяется номер четверти
int QuterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int x = ReadData("Введите координату х: ");
int y = ReadData("Введите координату y: ");

int res = QuterTest(x, y)

PrintResult("Точка находится в четверти № "+res);