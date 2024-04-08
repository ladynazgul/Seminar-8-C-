// Написать рекурсивную функцию показа чисел от 1 до N. N задано.

// string NumbersRec(int a, int N)
// {
//     if (a <= N) return $"{a} " + NumbersRec(a + 1, N);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersRec(1, 20));

// Вышеприведенную функцию я тупо содрала с лекции. Условие задачи она выполняет:)))

// А это то, что ребята на семинаре написали.

int N = 1;
int Max = 10;
void Function (int N, int Max)
{
    Console.WriteLine(N);
    N++;
    if (N <= Max)
        Function(N, Max);
}

Function(N, Max);