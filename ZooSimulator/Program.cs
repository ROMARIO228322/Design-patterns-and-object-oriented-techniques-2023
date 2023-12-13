using System.Collections;
using ZooSimulator.Context;
using ZooSimulator.Context.TypesOfBirds;
using ZooSimulator.Strategy;
using ZooSimulator.Strategy.ConcreteStrategy;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("");
        // First let's make some behaviours of birds.
        IFlight flapflight = new FlapWings();
        IFlight slide = new Slides();
        IFlight nofly = new NoFly();
        IFlight floats = new Floats();

        //Creating a birdList using List<T>.
        List<Bird> birdList = new List<Bird>();
        //Adding parts in the list. This will call the over BirdLists
        birdList.Add(new MallardDuck(flapflight) { Name = "MallardDuck",Color=" White" });
        birdList.Add(new Eagle(flapflight) { Name = "Bald Eagle's", Color = "Black,White and Grey" });
        birdList.Add(new Ostrich(nofly) { Name = "Fast Ostrich", Color = "Brown" });
        birdList.Add(new Penguin(slide) { Name = "Emperor Penguin", Color = "B&W" });
        birdList.Add(new RubberDuck(floats) { Name = "Rubber Duck's", Color = " Yellow" });

        //Counts the total number of birds number in the list.
        Console.WriteLine("Number of birds in the simultation: {0} ",birdList.Count);

        foreach (var bird in birdList)
        {
            Console.Write("Here is the {0} movement behaviour: ",bird.Name);
            bird.PerformFly();
        }
        
    }
}
