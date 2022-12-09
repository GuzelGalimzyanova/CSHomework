//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Диапазон любой, ввод зависит от пользователя. (размер, значения)

Console.WriteLine("Введите размер массива ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
Console.WriteLine("Введите элементы массива ");
for (int i = 0; i < length; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine(string.Join(" ", array));
Console.WriteLine("разница между max и min элементами = "+DiffMinMax(array));

double DiffMinMax(double[] Array)
{
    double min = Array[0];
    double max = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min)
            min = Array[i];
        else 
        if (Array[i] > max)
            max = Array[i];
    }
    return max - min;
}