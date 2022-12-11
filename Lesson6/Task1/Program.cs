// Задача : Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.
// 1 2 3 -4 1,2,-3,4, 

Console.WriteLine("Введите числа через запятую");
string text = Console.ReadLine();
string[] arrayStr = text.Split(",");
Console.WriteLine("количество положительных элементов = " + Positiv(arrayStr));

int Positiv(string[] array)
{
    int count = 0, k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.TryParse(arrayStr[i], out k))
        {
            if (k > 0)
                count++;
        }
    }
    return count;
}


