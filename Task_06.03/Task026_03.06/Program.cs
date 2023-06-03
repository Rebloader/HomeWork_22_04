// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void Main()
{
    Console.Clear();

    int n = ReadInt("Input size of matrix: ");
    int[,] matrix = CreateSpiralMatrix(n, n);
    PrintMatrix(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateSpiralMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    int num = 1;
    int minRow = 0;
    int minCol = 0;
    int maxRow = row - 1;
    int maxCol = col - 1;
    while (num <= row * col)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            matrix[minRow, i] = num++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            matrix[i, maxCol] = num++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--)
        {
            matrix[maxRow, i] = num++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            matrix[i, minCol] = num++;
        }
        minCol++;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t ");
        }
        System.Console.WriteLine();
    }
}

Main();