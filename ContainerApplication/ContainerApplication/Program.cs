using ContainerApplication;

Container cont1 = new LiquidContainer(true,100.0,1500.0,230.0,10000.0);

Container cont2 = new GasContainer(100.0,1500.0,230.0,10000.0, 12.0);

Container cont3 = new RefrigeratedContainer(100.0,1500.0,230.0,10000.0, Product.Eggs, 20.0);
Console.WriteLine(cont1);
Console.WriteLine(cont2);
Console.WriteLine(cont3);
cont1.loadContainer(130);
cont2.loadContainer(1500);
cont3.loadContainer(4500);

Console.WriteLine();

ContainerShip ship1 = new ContainerShip(10,2,1500);
ContainerShip ship2 = new ContainerShip(12, 4, 15000);

Console.WriteLine();

ship2.addContainer(cont3);
ship1.addContainers(new List<Container>(){cont1, cont2});
Console.WriteLine(ship1);
Console.WriteLine(ship2);

Console.WriteLine();
ship1.removeContainer(cont1.serial);
Console.WriteLine(ship1);

cont2.emptyContainer();

ship1.replaceContainer(cont2.serial, cont1);

