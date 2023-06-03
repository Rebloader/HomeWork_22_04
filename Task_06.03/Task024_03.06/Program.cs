// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Main()
{
    Console.Clear();
    int[,] matrix1 = GenerateMatrix(ReadInt("Input rows 1 matrix: "), ReadInt("Input columns 1 matrix: "), 1, 10);
    PrintMatrix(matrix1);
    int[,] matrix2 = GenerateMatrix(ReadInt("Input rows 2 matrix: "), ReadInt("Input columns 2 matrix: "), 1, 10);
    PrintMatrix(matrix2);
    if(matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
    {
        System.Console.WriteLine("Error, matrices is different");
    }
    System.Console.WriteLine("Result:");
    int[,] resultMatrix = CalculateMatrix(matrix1, matrix2);
    PrintMatrix(resultMatrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int column, int minNum, int maxNum)
{
    int[,] matrix = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minNum, maxNum + 1);
        }
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

int[,] CalculateMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] calculateMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < calculateMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < calculateMatrix.GetLength(1); j++)
        {
            calculateMatrix[i,j] = matrix1[i,j] * matrix2[i,j];
        }
    }
    return calculateMatrix;
}

Main();