// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine ());

number = Math.Abs(number);

if (number / 100 > 0)
{
    while (number >= 1000)
{
    number = number / 10;
}
int result = number%10;
Console.WriteLine($"Третья цифра {result}");
}
else
{
 Console.WriteLine("Третьей цифры нет");
}