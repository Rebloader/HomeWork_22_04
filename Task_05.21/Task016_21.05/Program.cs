// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Main()
{
    double[] arr = GenerateArr(5);
    PrintArray(arr);
    double max = arr.Max();
    double min = arr.Min();
    double diff = max - min;
    System.Console.WriteLine(diff);
}

double[] GenerateArr(int size)
{
    double[] genArr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        genArr[i] = Math.Round(rand.Next(0, 100) + rand.NextDouble(), 3);
    }
    return genArr;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "] ");
}

Main();