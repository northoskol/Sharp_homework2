// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string text)
{
    System.Console.Write(text);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int num = Prompt("Введите трехзначное число: ");
if (num < 100 & num >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число!");
    return;
}
Console.WriteLine($"Введенное число {num}");
int secondRank = num / 10 % 10;
Console.WriteLine($"Вторая цифра: {secondRank}");