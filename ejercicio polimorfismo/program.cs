using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Circulo c = new Circulo(5);
        Rectangulo r = new Rectangulo(4, 7);

        List<Forma> formas = new List<Forma>();
        formas.Add(c);
        formas.Add(r);

        foreach (var forma in formas)
        {
            Console.WriteLine($"Forma: {forma.Nombre}");
            Console.WriteLine($"Área: {forma.CalcularArea()}\n");
        }

        Console.ReadLine();
    }
}