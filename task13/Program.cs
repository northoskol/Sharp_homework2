// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


int Prompt(string text)
{
    Console.Write(text);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int ThirdNum(int num)
{
    while (num>999)
    {
        num/=10;
    }
    return num%10;
}
bool InspectNum(int num)
{
    if (num<100)
    {
        Console.WriteLine("Вы ввели не трехзначное число!");
        return false;
    }
    return true;
}
int num= Prompt("Введите число: ");
if (InspectNum(num))
{
    Console.WriteLine(ThirdNum(num));
}