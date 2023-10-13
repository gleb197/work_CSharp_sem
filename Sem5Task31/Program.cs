// Задайте массив из 12-ти элементов, заполненый случайными числами
//заполненый зи промежутка от -9 до 9, найдите сумму
//отрицательных и положительных элементов массива

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

(int, int) NegotivPositivSum(int[] arr)
{
    int posSum = 0;
    int negSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr [i]>0)
        {
        posSum = posSum + arr [i];
        }
        else
        {
        negSum += arr [i];
        }
    }
    return (posSum, negSum);
}


int[] array = GenArr(12, -9, 9);
PrintArr (array);
(int pos, int neg) sum = NegotivPositivSum(array);
Console.WriteLine(" Сумма > 0: "+sum.pos+" Сумма < 0: "+sum.neg);