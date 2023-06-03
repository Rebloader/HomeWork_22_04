// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void Main()
{
    Console.Clear();
    int[,] matrix = GenerateMatrix(ReadInt("Input rows: "), ReadInt("Input columns: "), 0, 10);
    System.Console.WriteLine("Начальный массив: ");
    PrintMatrix(matrix);
    int index = FindMatrixStringSum(matrix);
    Console.WriteLine($"Строка с наименьшей суммой: {index + 1}");
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

int FindMatrixStringSum(int[,] matrix)
{
    int minRowIndex = 0;
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            {
            array[i] += matrix[i,j];
            }
        }
        if(array[i] < array[minRowIndex]) minRowIndex = i;   
    }
    return minRowIndex;
}

Main();