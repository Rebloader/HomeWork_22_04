// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Input number from 100 to 999: ");
int num = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{(num / 10) % 10}");