// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int Factorial(int N)
{
    int x = 1;
    for (int i = 1; i <= N; i++)
    {
        x *= i;
    }
    return x;
}

for (int i = 0; i < N; i++)
{
    for (int k = 0; k <= N - i; k++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write(" ");
        Console.Write(Factorial(i) / (Factorial(k) * Factorial(i - k)));
    }
    Console.WriteLine();
}
