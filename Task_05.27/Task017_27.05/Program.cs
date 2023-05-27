// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Main()
{
    int[] input = ReadInt("Input numbers: ");
    PrintArray(input);
    int count = PositiveNums(input);
    System.Console.WriteLine(count);
}

int[] ReadInt(string text)
{
    System.Console.Write(text);
    int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return numbers;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int PositiveNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Main();