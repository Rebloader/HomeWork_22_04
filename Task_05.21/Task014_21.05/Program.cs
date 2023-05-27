// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
    int[] arr = FillArray(6, 100, 1000);
    PrintArray(arr);
    System.Console.WriteLine(FindNum(arr));

}

int[] FillArray(int size, int minNum, int maxNum)
{
    int[] array = new int[size];
    Random rand = new Random ();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(minNum, maxNum + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[" + string.Join(", ", array) + "] ");
}

int FindNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) count++;
    }
    return count;
}

Main();