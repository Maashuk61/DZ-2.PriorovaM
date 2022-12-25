// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number > 99 && number < 1000)
{
    int i = number / 10;
    int ii = i % 10;
    Console.WriteLine($"Вторая цифра из числа: {ii}");
}
else
{
    Console.WriteLine("Вы ввели НЕ трехзначное число");
}