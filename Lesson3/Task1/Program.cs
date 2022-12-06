//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num < 100000 && num > 9999)
{
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");
}
else
    Console.WriteLine("Ошибка ввода");

