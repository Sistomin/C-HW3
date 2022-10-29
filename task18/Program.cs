// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
void GetRange(int quarter)
{
    
    if (quarter == 1 )
    {
       Console.WriteLine($"Четверть {quarter} имеет диапозон [Х] больше нуля и [Y] больше нуля");
    }
    else if (quarter == 2 )
    {
       Console.WriteLine($"Четверть {quarter} имеет диапозон [Х] меньше нуля и [Y] больше нуля");
    }
    else if (quarter == 3 )
    {
       Console.WriteLine($"Четверть {quarter} имеет диапозон [Х] меньше нуля и [Y] меньше нуля");
    }
    else if (quarter == 4 )
    {
       Console.WriteLine($"Четверть {quarter} имеет диапозон [Х] больше нуля и [Y] меньше нуля");
    }
    else
    {
        Console.WriteLine("Вы ввели не корректную четверьть!");
    }

}
Console.WriteLine($"Введите номер четверти по оси координат: ");
int quarter = Convert.ToInt32(Console.ReadLine());
GetRange(quarter);


