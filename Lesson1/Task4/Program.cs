Console.Clear();
Console.WriteLine("Введите число больше единицы");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
if (n < 1)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
while (a + 2 <= n)
{
    Console.Write(a + 2 + " ");
    a = a + 2;
}
