using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        try
        {
            int cantidadNotas = 0;

            while (true)
            {
                try
                {
                    Console.Write("Ingrese la cantidad de notas a promediar: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                        throw new Exception("Entrada vacía. Por favor escriba un número entero mayor que cero.");

                    cantidadNotas = int.Parse(input.Trim(), NumberStyles.Integer, CultureInfo.CurrentCulture);

                    if (cantidadNotas <= 0)
                        throw new Exception("El número de notas debe ser mayor que cero.");

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato inválido: ingrese un número entero (p. ej. 3).");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            double suma = 0.0;
            for (int i = 1; i <= cantidadNotas; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Ingrese la nota #{i} (0 - 100): ");
                        string notaInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(notaInput))
                            throw new Exception("Entrada vacía. Escriba un número entre 0 y 100.");

                        double nota = double.Parse(notaInput.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture);

                        if (double.IsNaN(nota) || double.IsInfinity(nota))
                            throw new Exception("La nota no es un número válido.");

                        if (nota < 0 || nota > 100)
                            throw new Exception("La nota debe estar entre 0 y 100.");

                        suma += nota;
                        break; 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Formato inválido: ingrese un número (p. ej. 85 o 85.5).");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
            double promedio = suma / cantidadNotas;
            Console.WriteLine();
            Console.WriteLine($"Suma total: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nOcurrió un error inesperado: {ex.Message}");
            Console.WriteLine("Reinicie el programa y vuelva a intentarlo.");
        }
    }
}