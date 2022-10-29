// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();


void cube(int N)
{
    if (N > 0)
    {
        int count = 1;
        while (count < N)
        {
            int result = count * count * count;
            Console.Write(result + ", ");
            count++;
        }
        Console.Write(N * N * N);
    }
    else
    {
        Console.Write($"Введите число больше 1!");
    }
}
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
cube(N);