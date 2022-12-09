// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//Диапазон трехзначных чисел, ввод случайный.
int[] array = new int[10];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(99, 1000);
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine("Количество четных чисел = " + Even(array));

int Even(int[] massiv)
{
    int count = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] % 2 == 0)
            count++;
    }
    return count;
}