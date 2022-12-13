// Задайте двумерный массив (вручную) размером m×n, заполненный вещественными числами.

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {n} чисел(числа) через пробел и поставьте точку с запятой, повторите {m} раз(а) ");
string text = Console.ReadLine();
var element = text.Split(";") 
                  .Select(item => item.Split(" ").Select(s => Convert.ToDouble(s)))
                  .ToArray();

Console.WriteLine($"Результат: ");
for (int i = 0; i < element.Length; i++)
{
    Console.WriteLine(string.Join(' ', element[i]));
}
