﻿// 
//
//

// Генерация массива целых чисел и вывод на экран
int[] array = GenerateRandomArray(10, -100, 100);
PrintArray("Сгенерированный массив:\n", array);

// Сортировка массива методом вставки и вывод на экран
InsertionSort(array);
PrintArray("Сортировка методом вставки:\n", array);

// Обратная сортировка массива методом подсчета и вывод на экран
CountingSort(array);
PrintArray("Обратная сортировка методом подсчета:\n", array);

// Разница между первым и последним элементом (между максимальным и минимальным элементом массива)
int delta = array[0] - array[array.Length-1];
PrintResult($"Разница между максимальным и минимальным элементов: {delta}");

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Генерация массива
int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
    return array;
}

// Вывод массива
void PrintArray(string msg, int[] array)
{
    Console.Write(msg + "[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Сортировка массива вставками
void InsertionSort(int[] array)
{
    // Нулевой элемент считается отсортированной частью массива. 
    // Всё что правее - та часть, которую нужно отсортировать
    for (int i = 1; i < array.Length; i++)
    {
        int temp = array[i];
        int j = i - 1;

        // Поиск места для числа в левой части
        while (j >= 0 && array[j] > temp)
        {
            array[j + 1] = array[j];
            array[j] = temp;
            j--;
        }
    }
}

// Обратная сортировка массива подсчетом для произвольного целочисленного диапазона
void CountingSort(int[] array)
{
    // Поиск минимального и максимального значений в массиве
    int min = array[0];
    int max = array[0];
    foreach (int element in array)
    {
        if (element > max) { max = element; }
        else if (element < min) { min = element; }
    }

    // Поскольку индекс массива не может быть отрицательным, то приведем минимальное значение диапазона к нулю
    int correctionFactor = min != 0 ? -min : 0;
    max += correctionFactor;

    // Создание массива, в котором считаем количество вхождений каждого элемента исходного массива
    int[] count = new int[max + 1];
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i] + correctionFactor]++;
    }

    // Исходя из данных полученных в предыдущем шаге, формируем отсортированный массив
    int index = 0;
    for (int i = count.Length - 1; i >= 0; i--)
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i - correctionFactor;
            index++;
        }
    }
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}