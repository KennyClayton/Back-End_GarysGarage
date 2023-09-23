namespace Garage;

public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine("The blue Tesla slips past. Whooosh!");
    }
     public override void Turn()
    {
        Console.WriteLine("Straight ahead it charges....");
    }
    public override void Stop()
    {
        Console.WriteLine("...and gently comes to a stop");
    }
}