public class Forma
{
    public string Nombre { get; set; }

    public Forma(string nombre)
    {
        Nombre = nombre;
    }

    public virtual double CalcularArea()
    {
        return 0.0;
    }
}