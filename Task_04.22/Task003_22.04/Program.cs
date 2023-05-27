// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Enter number for check: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}