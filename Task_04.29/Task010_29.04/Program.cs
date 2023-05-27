// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNum(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] coordsA = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

//int[] coordsA = new int[3];
//coordsA[0] = InputNum("Input X coords point A: ");
//coordsA[1] = InputNum("Input Y coords point A: ");
//coordsA[2] = InputNum("Input Z coords point A: ");

//---------------------------------------------------------------------------------------------------------------------------------
int[] coordsB = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
//int[] coordsB = new int[3];
//coordsB[0] = InputNum("Input X coords point B: ");
//coordsB[1] = InputNum("Input Y coords point B: ");
//coordsB[2] = InputNum("Input Z coords point B: ");

double distance = Math.Sqrt(Math.Pow(coordsA[0] - coordsB[0], 2) + Math.Pow(coordsA[1] - coordsB[1], 2) + Math.Pow(coordsA[2] - coordsB[2], 2));
System.Console.WriteLine(Math.Round(distance, 2));

System.Console.WriteLine("вывод координат при помощи string.Join");
System.Console.WriteLine(string.Join(", ", coordsA));

System.Console.WriteLine("вывод координат при помощи цикла for");
for (int i = 0; i < coordsA.Length; i++)
{
    System.Console.WriteLine(coordsA[i] + ", ");
}