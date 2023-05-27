// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


System.Console.Write("Input 1 number: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input 2 number: ");
int b = Convert.ToInt32(Console.ReadLine());

//System.Console.WriteLine($"{Math.Pow (a,b)}");
int res = 1;
for (int i = 0; i < b; i++)
{
    res *= a;
}
System.Console.WriteLine(res);