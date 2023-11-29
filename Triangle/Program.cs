// See https://aka.ms/new-console-template for more information

// Usage example of the Triangle class
using TriangleLibrary;

namespace Triangle;

abstract class Program
{
    private static void Main(string[] args)
    {
        const double sideA = 3.0;
        const double sideB = 4.0;
        const double sideC = 5.0;
        
        var type = TriangleTypeChecker.DetermineTriangleType(sideA, sideB, sideC);

        Console.WriteLine($"Треугольник со сторонами {sideA}, {sideB}, {sideC} является {type} треугольником.");

        // Дополнительные примеры
        Console.WriteLine($"Треугольник со сторонами 2, 2, 3 является {TriangleTypeChecker.DetermineTriangleType(2, 2, 3)} треугольником.");
        Console.WriteLine($"Треугольник со сторонами 10, 6, 8 является {TriangleTypeChecker.DetermineTriangleType(10, 6, 8)} треугольником.");
    }
}