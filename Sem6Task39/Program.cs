// написать программу, которая перевернет одномерный массив
//последний элемент на первое мето, а последнй на первое

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


int[] SwapNewArray (int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i=0;i<arr.Length;i++)
    {
        outArr[arr.Length-1 -i] = arr[i];
    }

    return outArr;
}

void SwapArray (int[] arr)
{
    int buferElement = 0;
    for (int i=0;i<arr.Length/2;i++)
    {
        buferElement = arr[arr.Length-1 -i];
        arr[arr.Length-1 -i] = arr[i];
        arr[i] = buferElement;
    }
}




int[] arr = GenArr(15, 1, 100);
PrintArr (arr);
int[] swapArr1 = SwapNewArray (arr);
PrintArr (arr);
Console.WriteLine("Исходный массив ");
PrintArr (swapArr1);
Console.WriteLine("Перевернутый массив ");

SwapArray (arr);
PrintArr (arr);
Console.WriteLine("Перевернутый массив ");
