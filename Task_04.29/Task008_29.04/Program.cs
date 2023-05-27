// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNum(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int num = InputNum("Input number: ");

for (int i = 1; i <= num; i++)
{
    System.Console.Write($"{Math.Pow(i, 3)} ");
}