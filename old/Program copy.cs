// Задача : Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.
// 1 2 3 -4 1,2,-3,4, 
Console.WriteLine("Введите числа через пробел");
string text = Console.ReadLine();
Console.WriteLine("количество положительных чисел = " + Positiv(text));
// 1 2 5   -9  3  
int Positiv(string text)
{
    int count = 0;
    string t = "";
    int num = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == ' ')//является разделителем
        {
            if (t != "")//не является пустым
            {
                num = Convert.ToInt32(t);
                if (num > 0)
                {
                    count++;
                }
                t = "";
            }
        }
        else
        {
            t = t + text[i];
        }
        if (i == text.Length - 1)
        {
            if (t != "")//не является пустым
            {
                num = Convert.ToInt32(t);
                if (num > 0)
                {
                    count++;
                }
                t = "";
            }
        }
        Console.WriteLine($"{i} - {text[i]}, t= {t}, n = {num}, count = {count}");
    }
    return count;
}
