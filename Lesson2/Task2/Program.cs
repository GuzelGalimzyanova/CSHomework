Console.WriteLine("Введите число ");
string number = Console.ReadLine();
if (number.Length < 3)
    Console.WriteLine("Третьей цифры нет ");
else
    Console.WriteLine("Третья цифра = " + number[2]);
