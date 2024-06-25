using System;

class Program
{
    static void Main()
    {
        // Задаємо значення параметрів
        double R = 10; // Наприклад
        double r = 5;  // Наприклад
        double h = 3;  // Наприклад
        double t = Math.PI / 4; // Наприклад, в радіанах
        double mt = Math.PI / 2; // Наприклад, в радіанах

        // Обчислюємо значення m
        double m = r / R;

        // Обчислюємо x та y
        double x = (R + m * R) * Math.Sin(m * t) - h * Math.Cos(t + m * t);
        double y = (R + m * R) * Math.Sin(m * t) - h * Math.Cos(t + m * t);

        // Виводимо результати
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
    }
}
