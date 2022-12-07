//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int numberABS = Math.Abs(number);
while (numberABS > 0)
{
    sum = sum + numberABS % 10;
    numberABS = numberABS / 10;
}

Console.WriteLine("Сумма чисел равна " + sum);