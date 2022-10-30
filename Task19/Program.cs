// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void CheckingNumber(string number)
{
    if (number.Length == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine($"Ваше число: {number} - палиндром.");
        }
        else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
    }
    else
    {
        Console.WriteLine($"Введи пятизначное число");
    }
}

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
CheckingNumber(number);