// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Введите размер массива MxN");
Console.Write("Количество строк: M = ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: N = ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("МИНИМАЛЬНОЕ знчение массива: MIN = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("МАКСИМАЛЬНО знчение массива: MAX = ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив:");
int[,] array = FillArray(rows, columns, min, max);
PrintArray(array);

Console.WriteLine("Упорядочить каждую строку массива:");
array = SortDescending(array);
PrintArray(array);



int[,] FillArray(int arrayRows, int arrayColumns, int min, int max)
{
    Random random = new Random();
    int[,] createArray = new int[arrayRows, arrayColumns];

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            createArray[i, j] = random.Next(min, max + 1);
        }
    }
    return createArray;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortDescending(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < arr.GetLength(1) - 1; z++)
            {
                if (arr[i, z] < arr[i, z + 1])
                {
                    temp = arr[i, z];
                    arr[i, z] = arr[i, z + 1];
                    arr[i, z + 1] = temp;
                }      
            }
            
        }
    }
    return arr;
}

