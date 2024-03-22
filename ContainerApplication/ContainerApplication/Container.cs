namespace ContainerApplication;

public class Container
{
    public double massCargo;
    public double height;
    public double massContainer;
    public double depth;
    public string serial;
    public double maxPayload;
    public static int counter = 1;
    public string type = "X";

    public Container(double height, double massContainer, double depth, double maxPayload)
    {
        massCargo = 0;
        this.height = height;
        this.massContainer = massContainer;
        this.depth = depth;
        this.maxPayload = maxPayload;
    }

    public string generateSerial()
    {
        string result = "KON-" + type + "-" + counter;
        counter++;
        return result;
    }

    public virtual void emptyContainer()
    {
        massCargo = 0;
    }

    public virtual void loadContainer(double mass)
    {
        if (massCargo + mass <= maxPayload)
        {
            massCargo += mass;
        }
        else
        {
            throw new OverfillException("Too much weight! Container is overfilled!");
        }
    }

    public override string ToString()
    {
        return "Container " + serial + " (" + massContainer + " kg) with cargo mass of " + massCargo +
               " with max payload " + maxPayload + ". Height and depth: " + height + "x" + depth;
    }
}