Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
    Console.WriteLine("Этот день является выходным");
else if (num >= 1 && num <= 5)
    Console.WriteLine("Этот день является будним");
else
    Console.WriteLine("Ошибка ввода");
