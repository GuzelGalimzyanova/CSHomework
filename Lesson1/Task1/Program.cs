Console.Clear();
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > a)
    Console.WriteLine("max = " + b + ", min = " + a);
else
    Console.WriteLine("max = " + a + ", min = " + b);

