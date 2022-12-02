Console.Clear();
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max && b > c)
    max = b;
if (c > max && c > b)
    max = c;
if (b < max && c < max)
    max = a;
Console.WriteLine("Максимальное число равно "+max);



