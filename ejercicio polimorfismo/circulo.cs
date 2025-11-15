public class Circulo : Forma
{
    public double Radio { get; set; }

    public Circulo(double radio) : base("Círculo")
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}