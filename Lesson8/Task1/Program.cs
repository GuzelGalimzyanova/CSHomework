// Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива. (можно использовать готовую функцию)

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

int[] massiv = new int[n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
     massiv[j]=array2d[i,j];   
    }
    Array.Sort(massiv);
    Array.Reverse(massiv);
    for (int j = 0; j < n; j++)
    {
        array2d[i,j]=massiv[j];
    }
}

Console.WriteLine("новый массив: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}


