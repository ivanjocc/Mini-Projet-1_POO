using System;

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle newObject = new Rectangle(10, 10);

        double perimetre = newObject.Perimetre();
        double surface = newObject.Surface();

        newObject.Afficher();

        Console.WriteLine("Le perimetre est: {0} et la surface est: {1}", perimetre, surface);
    }
}
