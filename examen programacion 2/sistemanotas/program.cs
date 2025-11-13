using System;
using SistemaNotas;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Alumno alumno = new Alumno("Carlos Pérez", "20251001", "cperez@unah.edu.hn");
            Asignatura asignatura = new Asignatura("Programación II", "Ing. Ramírez", "Lunes y Miércoles 2:00 - 4:00 PM");
            Matricula matricula = new Matricula(alumno, asignatura);

            Console.WriteLine("Ingrese las 3 notas parciales:");
            Console.Write("Nota 1 (máximo 15): ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2 (máximo 15): ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3 (máximo 40): ");
            double n3 = double.Parse(Console.ReadLine());

            matricula.ValidarNotas(n1, n2, n3);

            matricula.NotasParciales.Add(n1);
            matricula.NotasParciales.Add(n2);
            matricula.NotasParciales.Add(n3);

            double notaFinal1 = matricula.CalcularNotaFinal();
            string mensaje1 = matricula.ObtenerMensajeNota(notaFinal1);

            double notaFinal2 = matricula.CalcularNotaFinal(n1, n2, n3);
            string mensaje2 = matricula.ObtenerMensajeNota(notaFinal2);

            Console.WriteLine("\n=== RESUMEN DE MATRÍCULA ===");
            Console.WriteLine($"Alumno: {alumno.Nombre}");
            Console.WriteLine($"Cuenta: {alumno.NumeroCuenta}");
            Console.WriteLine($"Correo: {alumno.Email}");
            Console.WriteLine($"Asignatura: {asignatura.NombreAsignatura}");
            Console.WriteLine($"Docente: {asignatura.NombreDocente}");
            Console.WriteLine($"Horario: {asignatura.Horario}");

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Nota Final (por lista): {notaFinal1} -> {mensaje1}");
            Console.WriteLine($"Nota Final (por parámetros): {notaFinal2} -> {mensaje2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese solo valores numéricos válidos.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de validación: {ex.Message}");
        }
    }
}