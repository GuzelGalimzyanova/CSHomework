/*Console.WriteLine("Введите число ");
string number = Console.ReadLine();
if (number.Length < 3)
    Console.WriteLine("Третьей цифры нет ");
else
    Console.WriteLine("Третья цифра = " + number[2]);*/

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
    num = -num;
if (num > 99)
{
    int a = num % 10;
    string b = a.ToString();
    Console.WriteLine("Третья цифра = " + b[0]);
}
else
    Console.WriteLine("Третьей цифры нет ");




