// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void FirstArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < 1; i++)
    {
        array[i] = rand.Next(0,50);
    }
}

void FillArray(int[] array)
{

    Random rand = new Random();
    for (int i = 1; i < array.Length - 1; i++)
    {
        array[i] = rand.Next(50,100);
    }
}

void LastArray(int[] array)
{
    Random rand = new Random();
    for (int i = 7; i < array.Length; i++)
    {
        array[i] = rand.Next(100,120);
    }
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    System.Console.Write(string.Join(", ", array));
    System.Console.Write("]");
}
int n = 8;
int[] arr = new int[n];

FirstArray(arr);
FillArray(arr);
LastArray(arr);
PrintArray(arr);