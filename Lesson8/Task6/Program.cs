// Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random rnd = new Random();
int min = 100, k = 0, l = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = rnd.Next(0, 100);
        Console.Write(array2d[i, j].ToString("00") + " ");
        if (array2d[i, j] < min)
        {
            min = array2d[i, j];
            k = i;
            l = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"минимальный элемент {min}");

int[,] arrayNew = new int[m - 1, n - 1];

for (int a = 0; a < arrayNew.GetLength(0); a++)
{
    bool shiftRow = a >= k;
    bool shiftColumn = false;
    for (int b = 0; b < arrayNew.GetLength(1); b++)
    {
        shiftColumn = b >= l;
        int columnIndex = b;
        if (shiftColumn)
        {
            if (shiftRow)
                arrayNew[a, b] = array2d[a + 1, b + 1];
            else
                arrayNew[a, b] = array2d[a, b + 1];
        }

        else
        {
            if (shiftRow)
                arrayNew[a, b] = array2d[a + 1, b];
            else
                arrayNew[a, b] = array2d[a, b];
        }
    }
}
Console.WriteLine();
PrintArray(arrayNew);

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
