namespace TriangleLibrary;

public static class TriangleTypeChecker
{
    private const double Precision = 1E-10; // Допускаемая погрешность при сравнении
    
    public static TriangleType DetermineTriangleType(double sideA, double sideB, double sideC)
    {
        // Сортировка сторон
        var (maxSide, minSide1, minSide2) = SortSides(sideA, sideB, sideC);

        // Проверка, можно ли образовать треугольник
        if (maxSide >= minSide1 + minSide2)
            return TriangleType.NotATriangle;

        // Вычисление квадратов сторон
        var maxSideSquared = maxSide * maxSide;
        var sumOfMinSidesSquared = minSide1 * minSide1 + minSide2 * minSide2;

        // Определение типа треугольника
        if (Math.Abs(maxSideSquared - sumOfMinSidesSquared) < Precision)
            return TriangleType.Right;
        
        return maxSideSquared > sumOfMinSidesSquared ? TriangleType.Obtuse : TriangleType.Acute;
    }

    private static (double, double, double) SortSides(double a, double b, double c)
    {
        if (a > b)
            (a, b) = (b, a);
        if (b > c)
            (b, c) = (c, b);
        if (a > b)
            (a, b) = (b, a);

        return (c, a, b); // c - максимальная сторона, a и b - две другие стороны
    }
}