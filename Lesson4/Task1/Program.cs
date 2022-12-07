//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//хотя в условиях задачи говорится про натуральную степень, 
// я сделала вариант с отрицательными числами

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
double result = 1;
int modulB = Math.Abs(b);
for (int i = 1; i <= modulB; i++)
{
    result = result * a;
}
if (b < 0)
    result = 1 / result;

Console.WriteLine("результат равен " + result);




