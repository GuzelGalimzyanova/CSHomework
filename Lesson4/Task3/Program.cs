//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1 вариант - вывод рандомных чисел

Random rnd = new Random();
int length = 8;
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = rnd.Next(-100, 100);
}
string result = string.Join(" ", array);
Console.WriteLine(result);


// 2 вариант - ввод чисел с терминала

/*
int[] array = new int[8];
int length = array.Length;
Console.WriteLine("Введите 8 чисел ");
for (int i = 0; i < length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
string result = string.Join(" ", array);
Console.WriteLine(result);*/
