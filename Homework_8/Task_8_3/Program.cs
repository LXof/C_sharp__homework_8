// Задача 58: 
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Задайте две матрицы");
Console.WriteLine("Матрица A");
Console.WriteLine("\tРазмер матрици MxN:");
Console.Write("\tВведите количество строк: M1 = ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\tВведите количество столбцов: N1 = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\tВведите МИНИМАЛЬНОЕ значение массива: min1 = ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.Write("\tВведите МАКСИМАЛЬНОЕ значение массива: max1 = ");
int max1 = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = createArray(m1, n1, min1, max1);
PrintArray(matrixA);

Console.WriteLine("Матрица B");
Console.WriteLine("\tРазмер матрици MxN:");
Console.Write("\tВведите количество строк: M2 = ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("\tВведите количество столбцов: N2 = ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("\tВведите МИНИМАЛЬНОЕ значение массива: min1 = ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("\tВведите МАКСИМАЛЬНОЕ значение массива: max1 = ");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = createArray(m2, n2, min2, max2);
PrintArray(matrixB);

Console.WriteLine("Произведение двух матриц: A * B");
int[,] newMatrix = GetProductOfTwoMatrices(matrixA, matrixB);
PrintArray(newMatrix);


int[,] createArray(int row, int columns, int min, int max)
{
    Random random = new Random();
    int[,] createArray = new int[row, columns];
    for (int i = 0; i < createArray.GetLength(0); i++)
    {
        for (int j = 0; j < createArray.GetLength(1); j++)
        {
            createArray[i, j] = random.Next(min, max + 1);
        }
    }
    return createArray;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine("");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("\t");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetProductOfTwoMatrices(int[,] matrixA, int[,] matrixB)
{
    int newRow = Math.Max(matrixA.GetLength(0), matrixB.GetLength(0));
    int newColumns = Math.Max(matrixA.GetLength(1), matrixB.GetLength(1));

    int[,] productOfTwoMatrices = new int[newRow, newColumns];

    for (int i = 0; i < productOfTwoMatrices.GetLength(0); i++)
    {
        for (int j = 0; j < productOfTwoMatrices.GetLength(1); j++)
        {
            for (int k = 0; k < productOfTwoMatrices.GetLength(1); k++)
            {
                productOfTwoMatrices[i, j] += (matrixA[i, k] * matrixB[k, j]);
                
            }
        }
    }
    return productOfTwoMatrices;
}