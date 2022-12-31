// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine ());

if (number >= 1 && number <= 5)
{
    Console.WriteLine("День недели не является выходным");
}

if (number == 6 || number == 7)
{
   Console.WriteLine("День недели является выходным"); 
}

if (number > 7)
{
Console.WriteLine("Введите число от 1 до 7"); 
}