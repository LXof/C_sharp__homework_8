// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

PrintResult(GetRowsSumElement(array));



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

void PrintResult(int[] arrSumRows)
{
    int numberRowMinSum = 0;
    int minSumRow = arrSumRows[0];

    Console.WriteLine("Сумма каждой строки:");

    for (int i = 0; i < arrSumRows.Length; i++)
    {
        Console.WriteLine($"\t{i + 1} строка: {arrSumRows[i]}");
        if (arrSumRows[i] < minSumRow)
        {
            numberRowMinSum = i + 1;
            minSumRow = arrSumRows[i];
        }
    }
    Console.WriteLine();

    Console.WriteLine($"Номер строки с наименьшей суммой эементов: {numberRowMinSum}");
}

int[] GetRowsSumElement(int[,] arr)
{
    int sumRow = 0;
    int[] sumRows = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRow += arr[i, j];
        }
        sumRows[i] = sumRow;
    }
    return sumRows;
}
