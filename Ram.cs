namespace Garage;

public class Ram : Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine("The blue Ram drives past. Brahhhhhh!");
    }
    public override void Turn()
    {
        Console.WriteLine("It veers left");
    }
    public override void Stop()
    {
        Console.WriteLine("The truck carefully parallel parks.");
    }
}