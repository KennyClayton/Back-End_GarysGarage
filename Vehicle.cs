namespace Garage;

public class Vehicle //define this separate class so we can give the below common properties to all other classes who call on it
{
    public string MainColor { get; set; } //give this property to all other classes who call on it
    public int MaximumOccupancy { get; set; } //give this property to all other classes who call on it
    public virtual void Drive() // make this property virtual though, so the child classes can choose whether to inherit Vroooom! or if they want to override and give their own sound
    {
        Console.WriteLine("Vrooom!");
    }
    public virtual void Turn() // make this property virtual though, so the child classes can choose whether to inherit Vroooom! or if they want to override and give their own sound
    {
        Console.WriteLine("Northward it banks...");
    }
    public virtual void Stop() // make this property virtual though, so the child classes can choose whether to inherit Vroooom! or if they want to override and give their own sound
    {
        Console.WriteLine("Screeeech! CRASH!");
    }
}