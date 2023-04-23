// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Input number from 1 to 7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a <= 5)
{
    System.Console.WriteLine("It's weekday");
}
else
{
    System.Console.WriteLine("It's weekends");
}