// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите размерность массива m, n, l");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());
int[,,] array3d = new int[m, n, l];
int[] uniqueNumbers = new int[m*n*l];
int count =0;

for (int k = 0; k < l; k++)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array3d[i, j, k] = GetUniqueNumber(uniqueNumbers,count);
            count++;
        }
    }
}
PrintArray(array3d);
int GetUniqueNumber(int[] array, int count)
{
    Random rnd = new Random();
    int number = rnd.Next(10, 100);
    
    if (Array.IndexOf(array, number) < 0)
    {
        array[count]=number;
        return number;
    }
    else
        return GetUniqueNumber(array,count);
}


void PrintArray(int[,,] array)
{
    for (int k = 0; k < l; k++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{array3d[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

