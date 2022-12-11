//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите поочередно значения  b1, k1, b2, k2 через enter");
double[] array = new double[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Intersection(array));

string Intersection(double[] Arr)
{
    double[] result = new double[2];
    if (Arr[1]!=Arr[3])
    {
    result[0] = (Arr[2] - Arr[0]) / (Arr[1] - Arr[3]);
    result[1] = Arr[3] * result[0] + Arr[2];
    return "координаты точек пересечения: "+(string.Join("; ", result));
    }
    else
    return "Возможно деление на ноль при равных k1 и k2, ошибка! ";
}


