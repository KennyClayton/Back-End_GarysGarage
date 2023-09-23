namespace Garage;

public class Zero : Vehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine("The green Zero screeches past. Reeeeeee!");
    }
    public override void Turn()
    {
        Console.WriteLine("It veers right");
    }
}