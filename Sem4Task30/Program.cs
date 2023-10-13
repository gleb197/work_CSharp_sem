// Написать программу, которая выводит массиф из восьми
//элементов заполненный 0 и 1 в случайном порядке

//длина массива
int ReadData(string smg)
{
    Console.WriteLine(smg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//генирация массива
int[] GenArr(int Length)
{
    int[] arr = new int[Length];
    Random rnd = new Random();
    for (int i = 0; i<arr.Length; i++)
    {
       arr [i] = rnd.Next(0,2);
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



int Length = ReadData("Введите длину массива: ");
int[] arr = GenArr(Length);
PrintArr(arr);