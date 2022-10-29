// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();
double Distance(int x1, int y1, int x2, int y2)
{
    double distance;
    distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    
    return distance;
}

Console.WriteLine($"Введите координату по оси Х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату по оси Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату по оси Х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координату по оси Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
Console.WriteLine($"Растояние между точками равно {Math.Round(distance, 2)}");
