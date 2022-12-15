//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine("Введите числа m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
{
    Console.WriteLine("числа должны быть больше нуля");
    Environment.Exit(0);
}

Console.WriteLine("результат функции Аккермана: " + Akkerman(m, n));

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    return 0;
}
