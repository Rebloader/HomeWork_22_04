// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
    Console.Clear();
    int M = ReadInt("Input M: ");
    int N = ReadInt("Input N: ");
    if (M < N) System.Console.WriteLine(SumNumbers(M, N));
    if (N < M) System.Console.WriteLine(SumNumbers(N, M));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N)
{
    if (M == N) return N;
    return M + SumNumbers(M + 1, N);
}

Main();