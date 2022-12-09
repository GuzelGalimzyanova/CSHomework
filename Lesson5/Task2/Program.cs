//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//Диапазон любой, ввод зависит от пользователя. (размер, значения)

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine("сумма элементов = " + Sum(array));

int Sum(int[] Array)
{
    int summa = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i % 2 != 0)
            summa = summa + Array[i];
    }
    return summa;
}