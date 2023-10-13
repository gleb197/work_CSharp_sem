// найти произведение пар чисел в одномерном массиве
//парой считаем первый и последний, второй и предпоследний
//и т.д. Результат записать в другой массив


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
    System.Console.Write("[");
    for (int i = 0; i<array.Length-1; i++)
            System.Console.Write(array[i]+", ");
        System.Console.Write(array[array.Length-1]+"]");
          
}


int[] ConvertArr (int[] arr)
{
    int[]outArr = new int[arr.Length/2];
    for (int i=0; i<arr.Length/2; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length-1-i];
    }
    return outArr;
}


int[] arr = GenArr(12, -9, 9);
PrintArr(arr);
PrintArr(ConvertArr(arr));
