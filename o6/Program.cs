using CarSpace;
using CarUtilities;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a car model:");
        string model = Console.ReadLine();
        Car car = new Car(model);
        car.Accelerate();
        car.Accelerate();
        car.Brake();
    }
}