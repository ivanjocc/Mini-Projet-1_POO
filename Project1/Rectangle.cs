using System;


public class Rectangle
{
    private double largeur;
    private double longueur;

    public Rectangle(double largeur, double longueur)
    {
        this.largeur = largeur;
        this.longueur = longueur;
    }

    public double Perimetre()
    {
        return (this.largeur + this.longueur) * 2;
    }

    public double Surface()
    {
        return (this.largeur * this.longueur);
    }

    public void Afficher()
    {
        Console.WriteLine("Le largeur est: {0} et le longueur est: {1}", this.largeur, this.longueur);
    }
}