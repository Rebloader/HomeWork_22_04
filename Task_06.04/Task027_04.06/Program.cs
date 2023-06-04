// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillNumbers(int number)
{
    if(number < 1) return;
    System.Console.Write(number + " ");
    FillNumbers(number-1);
}

Console.Clear();
FillNumbers(ReadInt("Input number: "));