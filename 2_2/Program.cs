// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine ());
if (number >= 100 || number <= -100)
    {      
    while (number > 999 || number < -1000)
    {
        if (number > 99 || number < 1000)
        if (number < -99 || number > -1000)
        {
            int i = number % 10;
            Console.WriteLine($"Третья цифра: {i}");
        }
        else 
        {
            int namber = number / 10;
        }
    }
    }     
else if (number > 99 || number < 1000)
{
i = number % 10;
Console.WriteLine($"Третья цифра: {i}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
