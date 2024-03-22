namespace ContainerApplication;

public class RefrigeratedContainer : Container
{
    public Product product;
    public double temperature;
    public RefrigeratedContainer(double height, double massContainer, double depth, double maxPayload, Product product, double temperature) : base(height, massContainer, depth, maxPayload)
    {
        this.product = product;
        this.temperature = temperature;
        if (temperature < ((int)this.product)/10.0)
        {
            throw new ArgumentException("Temperature inside a container is lower than needed for provided product");
        }

        type = "C";
        serial = generateSerial();
    }
    
    public override string ToString()
    {
        return "Container " + serial + " (" + massContainer + " kg) with cargo mass of " + massCargo +
               " with max payload " + maxPayload + ". Height and depth: " + height + "x" + depth + ". With product and temperature: " + product + " and " + temperature;
    }
}