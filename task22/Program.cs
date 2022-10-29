// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();


void sqr(int N)
{
    if (N > 0)
    {
        int count = 1;
        while (count <= N)
        {
            Console.Write(count * count + " ");
            count++;
        }
    }
    else
    {
        Console.Write($"Введите число больше 1!");
    }
}
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
sqr(N);

