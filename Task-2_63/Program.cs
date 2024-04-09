// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] FillMatrix(int m, int n, int start, int end)
{
    int[,] newMatrix = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newMatrix[i, j] = new Random().Next(start, end);
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

(int, int) FindMinIndex(int[,] someMatrix)
{
    int minimum = someMatrix[0, 0];
    int jMinimum = 0;
    int iMinimum = 0;
    for (int i = 0; i < someMatrix.GetLength(0); i++)
    {
        if (someMatrix[i, 0] < minimum)
        {
            minimum = someMatrix [i, 0];
            iMinimum = i;
            jMinimum = 0;
        }
        for (int j = 0; j < someMatrix.GetLength(1); j++)
        {
            if (someMatrix[i, j] < minimum)
            {
                minimum = someMatrix[i, j];
                jMinimum = j;
                iMinimum = i;
            }
        }
    }
    return (iMinimum, jMinimum);
}

int[,] ColumnDel(int[,] matrix, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < column; j++)
        {
            newMatrix[i, j] = matrix[i, j];
        }
        for (int j = column; j < matrix.GetLength(1) - 1; j++)
        {
            newMatrix[i, j] = matrix[i, j + 1];
        }
    }
    return newMatrix;
}

int[,] RowDel(int[,] matrix, int row)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < row; i++)
        {
            newMatrix[i, j] = matrix[i, j];
        }
        for (int i = row; i < matrix.GetLength(0) - 1; i++)
        {
            newMatrix[i, j] = matrix[i + 1, j];
        }
    }
    return newMatrix;
}

int[,] matrix = FillMatrix(4, 5, 0, 40);
PrintMatrix(matrix);
Console.WriteLine();
(int, int) indexes = FindMinIndex(matrix);
Console.WriteLine($"{indexes.Item1}  {indexes.Item2}");
int column = indexes.Item2;
int row = indexes.Item1;
int[,] matrixWithoutColumn = ColumnDel(matrix, column);
int[,] matrixWithoutRow = RowDel(matrixWithoutColumn, row);
PrintMatrix(matrixWithoutRow);