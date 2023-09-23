namespace Garage;

public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine("The yellow plane flies low. Zoooooom!");
    }
    public override void Stop()
    {
        Console.WriteLine("Cruising ever lower, its wheels finally caress the earth");
    }
}