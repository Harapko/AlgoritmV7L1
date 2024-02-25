namespace AlgoritmV7L1;

public class Logic
{
    public static double FindY(double a, double b)
    {
        double x = 2 * (Math.Abs(b)) + a;
        return Math.Sqrt(Math.Abs(Math.Pow(x,2)) - 3 * x) + 8;
    }

    public static void Age(int tanyaAge, int mityaAge)
    {
        int averageAge = (tanyaAge + mityaAge) / 2;
        Console.WriteLine($"Average: {averageAge}");
        Console.WriteLine($"Different age Tanya {tanyaAge - averageAge}");
        Console.WriteLine($"Different age Mitya {mityaAge - averageAge}");
    }

    public static double FindYSecond(double a, double b)
    {
        double x = (2 * a + 3) / 4;
        return Math.Pow(x, 3) + 5 * x + b;
    }

    public static void Square(double side)
    {
        double diagonal = side * Math.Sqrt(2);
        double perimeter = side * 4;
        double area = Math.Pow(side, 2);
        Console.WriteLine($"Diagonal: {diagonal}\nPerimeter: {perimeter}\nArea: {area}");
    }

    public static void Decor()
    {
        Console.Write("Press any key...");
        Console.ReadKey();
        Console.Clear();
    } 
}