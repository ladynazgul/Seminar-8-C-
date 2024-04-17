// Объединить массивы

using System.Data.SqlTypes;
using System.Diagnostics;

int[] a = new int[] { 1, 2, 3 };
int[] b = new int[] { 4, 5, 6 };
int[] c = a.Concat(b).ToArray();
Console.WriteLine(String.Join(' ', c));

int[] createArray(int[] c)
{
    int[] cd = new int[6];
    for (int i = 0; i < cd.Length; i++)
    {
        cd[i] = c[i] * 2;
    }
    return cd;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

// int[] d = createArray(c);
// PrintArray(d);

// Масштабирование

double k = 1.1;                          // Коэффициент масштабирования
double[] pointA = { 0, 0 };              // Координаты точек
double[] pointB = { 1, 2 };
double[] pointC = { 4, 2 };
double[] pointD = { 4, 0 };
char[] pointName = { 'A', 'B', 'C', 'D' };

double[] c1 = pointA.Concat(pointB).ToArray();
double[] c2 = c1.Concat(pointC).ToArray();
double[] c3 = c2.Concat(pointD).ToArray();

double[] GetScalingCoords(double[] arr, double k)
{
    double[] newCoords = new double[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < 2) newCoords[i] = arr[i];
        else if (i > 1 && i % 2 == 0) newCoords[i] = arr[i] * k - arr[0] * (k - 1);
        else if (i > 1 && i % 2 != 0) newCoords[i] = arr[i] * k - arr[1] * (k - 1);
    }
    return newCoords;
}

Console.WriteLine();
Console.WriteLine("---");
Console.WriteLine(String.Join(' ', c3));

Console.WriteLine("---");
double[] newCoords = GetScalingCoords(c3, k);
PrintArray(newCoords);

// Проверка введенного значения

while (true)
{
    int aaa = 0;
    Console.Write("Введите число:   ");
    bool flag = int.TryParse(Console.ReadLine(), out aaa);
    if (flag) Console.WriteLine("       Это число");
    else Console.WriteLine("      Это не число");
}