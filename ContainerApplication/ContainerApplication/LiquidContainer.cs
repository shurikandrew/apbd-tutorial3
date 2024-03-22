namespace ContainerApplication;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool isHazard;
    
    public LiquidContainer(bool isHazard,double height, double massContainer, double depth, double maxPayload) : base(height, massContainer, depth, maxPayload)
    {
        this.isHazard = isHazard;
        type = "L";
        serial=generateSerial();
    }

    public override void loadContainer(double mass)
    {
        if (isHazard)
        {
            if (massCargo + mass <= maxPayload*0.5)
            {
                massCargo += mass;
            }
            else
            {
                Console.WriteLine("It is dangerous to perform this operation!");
            }
        }
        else
        {
            if (massCargo + mass <= maxPayload*0.9)
            {
                massCargo += mass;
            }
            else
            {
                Console.WriteLine("It is dangerous to perform this operation!");
            }
        }
        
    }

    public void informationHazard()
    {
        Console.WriteLine("This liquid container has a hazardous event: " + serial);
    }
    
    public override string ToString()
    {
        return "Container " + serial + " (" + massContainer + " kg) with cargo mass of " + massCargo +
               " with max payload " + maxPayload + ". Height and depth: " + height + "x" + depth + ". Is hazard " + isHazard;
    }
}