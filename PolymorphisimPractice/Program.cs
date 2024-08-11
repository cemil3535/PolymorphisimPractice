// See https://aka.ms/new-console-template for more information
using PolymorphisimPractice;
using static PolymorphisimPractice.GeometricShape;

public class Program
{
    public static void Main(string[] args)
    {
        // Object create and use polymorphisim
        GeometricShape square = new Square(5);
        square.AreaCalculate();
        GeometricShape rectangle = new Rectangle(4,7); 
        rectangle.AreaCalculate();
        GeometricShape rightTriangle = new RightTriangle(6, 9);
        rightTriangle.AreaCalculate();

        // print area calculate
        Console.WriteLine("Kare Alani: " + square.AreaCalculate());
        Console.WriteLine("Dikdortgen Alani: " + rectangle.AreaCalculate());
        Console.WriteLine("Dik Ucgen Alnai: " + rightTriangle.AreaCalculate());
    }
}
