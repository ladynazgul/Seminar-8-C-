// Написать рекурсивную функцию определения суммы цифр числа N, введённого с клавиатуры

// int Function (int n)
// {
//     if (n < 10) return n;
//     else return Function(n/10) + n%10;
// }
// int N = 5647;
// Console.WriteLine($"Сумма цифр числа {N} равна {Function(N)}");


// int SumNumber(int n)
// {
//     if (n == 0)
//         return 0;
//     return n%10 + SumNumber(n/10);
// }



// Использование тернарного оператора, получается еще короче

int SumNumber (int n)
{
    return n == 0 ? 0 : n%10 + SumNumber(n/10); // синтаксис этой фигни: значение - вопрос - значение, если условие истинно - двоеточие - значение, если условие ложно
}

Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Sum of digits: {SumNumber(n)}");

// Если в функции содержится только один оператор return, то можно все записать в 1 строку:

// int SumNumber (int n) => n == 0 ? 0 : n % 10 + SumNumber(n / 10);