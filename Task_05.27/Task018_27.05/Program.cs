// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main()
{
    int[] array = ReadInt("Input (k1) (b1), (k2) (b2): ");
    PrintArr(array);
    if(!CheckLines(array)) return;
    double crossPoint1 = FindX(array);
    double crossPoint2 = FindY(array);
    System.Console.WriteLine($"Point is: {crossPoint1}, {crossPoint2}");
}

int[] ReadInt(string text)
{
    System.Console.Write(text);
    int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return numbers;
}

void PrintArr(int[] array)
{
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

bool CheckLines(int[] array)
{
    if(array[0] == array[2] && array[1] == array[3]) 
    {
        System.Console.WriteLine("Линии совпадают");
        return false;
    }
    if(array[0] * array[3] == array[2] * array[1])
    {
        System.Console.WriteLine("Линии параллельны");
        return false;
    }
return true;
}

double FindX(int[] array)
{
    double x = (array[2] - array[0]) / (array[1] - array[3]);
    return x;
}

double FindY(int[] array)
{
    double y = array[0] * FindX(array) + array[1];
    return y;
}

Main();