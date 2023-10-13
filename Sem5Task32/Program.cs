// Напишите программу, которая заменит элементы массива,
// положительные элементы замените на соответствующие отрицательные
// и наоборот

//генирация массива
int[] GenArr(int Length, int lowBorder, int highBorder)
{
    int[] arr = new int[Length];
       for (int i = 0; i<arr.Length; i++)
    {
       arr [i] = new Random().Next(lowBorder, highBorder+1);
    }
    return arr;
}

//печать массива
void PrintArr (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<arr.Length-1; i++)
            Console.Write(arr[i]+", ");
        Console.Write(arr[arr.Length-1]+"]");
          
}


void InversArr (int [] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        arr[i]*=-1;
    }
}

int[] array = GenArr(12, -9, 9);
PrintArr (array);
InversArr (array);
PrintArr (array);

