// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("input number: ");
string? str = Console.ReadLine();

if (str.Length == 5)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
    System.Console.WriteLine("True");
    }
    else
    {
    System.Console.WriteLine("False");
    }
}
else
{
    System.Console.WriteLine("Error");
}
