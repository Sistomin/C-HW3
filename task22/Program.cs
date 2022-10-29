// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();


void sqr(int N)
{
    if (N > 0)
    {
        int count = 1;
        while (count <= N)
        {
            int result = count * count;
            Console.Write(result + ", ");
            count++;
        }
        Console.Write(N * N);
    }
    else
    {
        Console.Write($"Введите число больше 1!");
    }
}
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
sqr(N);

