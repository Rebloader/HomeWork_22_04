// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num > 1000)
{
    num /= 10;
}

if (num < 100)
{
    System.Console.WriteLine("Error!");
}

else
{
    num %= 10;
    System.Console.WriteLine(num);
}