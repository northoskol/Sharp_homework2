// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int Prompt(string text)
{
    Console.Write(text);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool Weekend(int day)
{
    if (day > 5)
    {
        return true;
    }
    return false;
}
bool InspectDay(int num)
{
    if (num > 0 & num <= 7)
    {
        return true;
    }
    Console.WriteLine("В неделе 7 дней!");
    return false;
}
int day = Prompt("Введите день недели: ");
if (InspectDay(day))
{
    if (Weekend(day))
    {
        Console.WriteLine("Сегодня выходной!");
    }
    else
    {
        Console.WriteLine("Марш работать!");
    }
}