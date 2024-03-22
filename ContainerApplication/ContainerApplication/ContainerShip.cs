namespace ContainerApplication;

public class ContainerShip
{
    public List<Container> containersList = new List<Container>();
    public double maxSpeed;
    public int maxContainerCount;
    public double maxContainerWeight;
    public int containerCount=0;
    public double containerWeight = 0;

    public ContainerShip(double maxSpeed, int maxContainerCount, double maxContainerWeight)
    {
        this.maxSpeed = maxSpeed;
        this.maxContainerCount = maxContainerCount;
        this.maxContainerWeight = maxContainerWeight;
    }

    public bool addContainer(Container container)
    {
        if (containerCount + 1 <= maxContainerCount &&
            containerWeight + container.massCargo + container.massContainer <= maxContainerWeight*1000)
        {
            containerCount += 1;
            containerWeight += container.massContainer + container.massCargo;
            containersList.Add(container);
            return true;
        }
        else
        {
            Console.WriteLine("No space for a given container!");
            return false;
        }
    }

    public void addContainers(List<Container> containers)
    {
        for (int i = 0; i < containers.Count; i++)
        {
            if (!addContainer(containers[i]))
            {
                break;
            }
        }
        
    }

    public void removeContainer(string serialNum)
    {
        for (int i = 0; i < containersList.Count; i++)
        {
            if (containersList[i].serial == serialNum)
            {
                containerCount -= 1;
                containerWeight -= containersList[i].massContainer - containersList[i].massCargo;
                containersList.RemoveAt(i);
                break;
            }
        }
    }

    public void replaceContainer(String serial, Container container)
    {
        for (int i = 0; i < containersList.Count; i++)
        {
            if (containersList[i].serial == serial)
            {
                if (containerWeight + container.massCargo + container.massContainer - containersList[i].massCargo -
                    containersList[i].massContainer <= maxContainerWeight * 1000)
                {
                    containerCount -= 1;
                    containerWeight -= containersList[i].massContainer - containersList[i].massCargo;
                    containersList.RemoveAt(i);
                    addContainer(container);
                }
                else
                {
                    Console.WriteLine("Operation failed. Not enough space");
                }
                break;
            }
        }
    }

    public override string ToString()
    {
        return "This ship has max speed " + maxSpeed + ". It has max capacity of " + maxContainerWeight + " tons and " +
               maxContainerCount + " containers. Now it has " + containerWeight + " kg and " + containerCount +
               " containers";
    }
}