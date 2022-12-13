// Задайте двумерный массив (вручную) из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите {n} чисел(числа) через запятую");
    string text = Console.ReadLine();
    string[] arrayNew = text.Split(",");
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = Convert.ToInt32(arrayNew[j]);
    }
}

double[] array = new double[n];
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + array2d[i, j];
    }
    array[j] = Math.Round(sum / m, 2);

}
Console.WriteLine("Средние арифметические по столбцам: " + string.Join(";", array));
