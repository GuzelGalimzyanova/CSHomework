// Напишите программу, которая заполнит спирально массив 4 на 4.
Console.WriteLine("Введите количество строк и столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int [m, n];

int startLine = 0, startColumn = 0, endLine = n - 1, endColumn = m - 1, count = 1;
while (startLine <= endLine && startColumn <= endColumn)
{
    for (int i = startColumn; i <= endColumn; i++)
    {
        array2d[startColumn, i] = count;
        count++;
    }
    startLine++;

    for (int i = startLine; i <= endLine; i++)
    {
        array2d[i, endLine] = count;
        count++;
    }
    endColumn--;

    for (int i = endColumn; i >= startColumn; i--)
    {
        array2d[endLine, i] = count;
        count++;
    }
    endLine--;

    for (int i = endLine; i >= startLine; i--)
    {
        array2d[i, startColumn] = count;
        count++;
    }
    startColumn++;
}

Console.WriteLine("Полученная таблица:");
PrintArray(array2d);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("00") + " ");
        }
        Console.WriteLine();
    }
}

