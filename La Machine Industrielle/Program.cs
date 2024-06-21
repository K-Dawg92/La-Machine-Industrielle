using La_Machine_Industrielle;
public class program
{
    public static void Main(String[] args)

    {
        Console.WriteLine("Please enter the required amount of litres of beer you want?");
        double availableBeerVolume = double.Parse(Console.ReadLine());

        Console.WriteLine("Now enter the amount of empty bottles are required");
        int availableBottles = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the amount of caps required, should be the same as empty bottles");
        int availablecapsules = int.Parse(Console.ReadLine());

        BeerEncapsulator bottle1 = new BeerEncapsulator(availableBeerVolume, availableBottles,availablecapsules);
        Console.WriteLine($"Available Beer Volume {bottle1.AvailableBeerVolume}");
        Console.WriteLine($"Available Bottles {bottle1.AvailableBottles}");
        Console.WriteLine($"Available Caps {bottle1.AvailableCapsules}");

        bottle1.ProduceEncapsulatedBeerBottles(10);
        bottle1.ProduceEncapsulatedBeerBottles(50);
        bottle1.ProduceEncapsulatedBeerBottles(500);

    }
}

