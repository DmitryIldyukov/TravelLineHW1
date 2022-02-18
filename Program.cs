using Travel;

class Program
{
    public static void Main(string[] args)
    {
        int MajorAxis;
        int MinorAxis;
        Console.Write("Введите малый радиус: ");
        MinorAxis = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите больший радиус: ");
        MajorAxis = Convert.ToInt32(Console.ReadLine());

        try
        {
            Ellipse ellipse = new Ellipse(MajorAxis, MinorAxis);
            double square = ellipse.GetSquare();
            double lenght = ellipse.GetLength();
            Console.WriteLine("Площадь эллипса: " + square);
            Console.WriteLine("Длина окружности эллипса: " + lenght);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}