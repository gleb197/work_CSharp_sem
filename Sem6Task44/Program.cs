// не используя рекурсию выведите первые N чисел Фибоначчи
//первые два числа Фибоначчи 0, 1

int n = ReadData("Введите количество чисел Фибоначчи (N): ");
PrintFibonacciNumbers(n);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод числа с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печати чисел Фибоначчи
void PrintFibonacciNumbers(int n)
{
    int first = 0;
    int second = 1;
    int next = 0;

    for (int i = 0; i < n; i++)
    {
        Console.Write(first + " ");
        next = first + second;
        first = second;
        second = next;
    }
}