namespace ContainerApplication;

public class GasContainer: Container, IHazardNotifier
{
    public double pressure;
    public GasContainer(double height, double massContainer, double depth, double maxPayload, double pressure) : base(height, massContainer, depth, maxPayload)
    {
        this.pressure = pressure;
        type = "G";
        serial = generateSerial();
    }

    public override void emptyContainer()
    {
        massCargo *= 0.05;
    }
    
    public void informationHazard()
    {
        Console.WriteLine("This gas container has a hazardous event: " + serial);
    }
    
    public override string ToString()
    {
        return "Container " + serial + " (" + massContainer + " kg) with cargo mass of " + massCargo +
               " with max payload " + maxPayload + ". Height and depth: " + height + "x" + depth + ". With pressure " + pressure;
    }
}