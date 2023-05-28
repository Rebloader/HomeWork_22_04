// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Main()
{
    int[,] matrix = GenerateMatrix(ReadInt("Input rows: "), ReadInt("Input columns: "), 0, 50);
    PrintMatrix(matrix);
    int number = FindElement(matrix, ReadInt("Input rows №: "), ReadInt("Input columns №: "));
    if (number != -1) System.Console.WriteLine(number);
    else System.Console.WriteLine("No number in matrix");
    
}
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int minNum, int maxNum)
{
    int[,] matrix = new int[row,col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(minNum, maxNum + 1);
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

int FindElement(int[,] matrix, int row, int col)
{ 
    if(row < matrix.GetLength(0) && col < matrix.GetLength(1)) return matrix[row-1, col-1];
    return -1;
}

Main();