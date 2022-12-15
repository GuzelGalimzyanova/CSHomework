//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if(m>n)
{
    Console.WriteLine("m должно быть меньше n");
    Environment.Exit(0); 
}
Console.WriteLine($"Сумма от {m} до {n} включительно равна "+ Numbers(m, n));
int Numbers(int m, int n)
{
    if (n<=m)
        return n;
    return n + Numbers(m, n-1);
}
