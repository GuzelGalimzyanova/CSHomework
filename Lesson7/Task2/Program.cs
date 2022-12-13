// Напишите программу, которая на вход принимает элемент в двумерном массиве, 
//и возвращает индекс этого элемента или же указание, что такого элемента нет. 
//Если элементов несколько, то выводим позицию каждого. Двумерный массив задаётся на ваш выбор.

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число k");
int k = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = random.Next(-10, 11);
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}

int count = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (array2d[i, j] == k)
        {
            count++;
            Console.WriteLine($"индекс искомого элемента [{i},{j}]");
        }
    }
}
if (count == 0)
    Console.WriteLine("такого числа в массиве нет");

