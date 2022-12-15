// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов. (можно использовать готовую функцию)
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
//1 строка

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = rnd.Next(0, 10);
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}

int[] massiv = new int[m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        massiv[i] += array2d[i, j];
    }
}

int min = massiv[0];
int index = 0;
for (int i = 0; i < m; i++)
{
    if (massiv[i] < min)
    {
        min = massiv[i];
        index = i;
    }
}
Console.WriteLine($"наименьшая сумма элементов в строке {index+1}");



