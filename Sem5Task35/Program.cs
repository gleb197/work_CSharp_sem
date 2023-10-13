// Задать одномерный массив из 123 случайных чисел,
//найти количество элементов массива, которое лежит
// в отреске от 10 до 99

//генирация массива
int[] GenArr(int Length, int lowBorder, int highBorder)
{
    int[] array = new int[Length];
       for (int i = 0; i<array.Length; i++)
    {
       array [i] = new Random().Next(lowBorder, highBorder+1);
    }
    return array;
}

//печать массива
void PrintArr (int[] array)
{
    Console.Write("[");
    for (int i = 0; i<array.Length-1; i++)
            Console.Write(array[i]+", ");
        Console.Write(array[array.Length-1]+"]");
          
}


int CountElm(int[] array, int min, int max)
{
    int count = 0;
    for(int i=0;i<array.Length;i++)
        if((array[i]>min)&&(array[i]<max))
           count++;
    return count;
}

//Печать резльтата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


int[] arr = GenArr(123, -199, 199);
PrintArr (arr);
int min = 9;
int max =100;
int count = CountElm(arr, min, max);
PrintResult($" в заданном диапазоне {count} элементов");