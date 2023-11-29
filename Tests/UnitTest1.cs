using TriangleLibrary;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void DetermineTriangleType_RightAngled_ReturnsRight()
    {
        double a = 3, b = 4, c = 5; // стороны прямоугольного треугольника
        
        var result = TriangleTypeChecker.DetermineTriangleType(a, b, c);
        
        Assert.Equal(TriangleType.Right, result);
    }

    [Fact]
    public void DetermineTriangleType_AcuteAngled_ReturnsAcute()
    {
        double a = 3, b = 4, c = 4; // стороны остроугольного треугольника
        
        var result = TriangleTypeChecker.DetermineTriangleType(a, b, c);
        
        Assert.Equal(TriangleType.Acute, result);
    }

    [Fact]
    public void DetermineTriangleType_ObtuseAngled_ReturnsObtuse()
    {
        double a = 3, b = 4, c = 6; // стороны тупоугольного треугольника
        
        var result = TriangleTypeChecker.DetermineTriangleType(a, b, c);
        
        Assert.Equal(TriangleType.Obtuse, result);
    }
}