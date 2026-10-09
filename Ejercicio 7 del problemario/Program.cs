
using System;

// Clase que representa al brazo robótico
class BrazoRobotico
{
    // Propiedades del brazo robótico
    public double tiempoTomar;
    public double tiempoTrasladar;
    public double tiempoSoltar;
    public int ciclos;
    public double tiempoCiclo;
    public double tiempoAcumulado;

    // Método para capturar los datos
    public void CapturarDatos()
    {
        Console.WriteLine("SIMULACION DE UN BRAZO ROBOTICO");

        Console.Write("Tiempo para tomar la pieza (s): ");
        tiempoTomar = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Tiempo para trasladar la pieza (s): ");
        tiempoTrasladar = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Tiempo para soltar la pieza (s): ");
        tiempoSoltar = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Numero de ciclos a simular: ");
        ciclos = int.Parse(Console.ReadLine() ?? "0");

        // Se verifica que el numero de ciclos sea valido
        while (ciclos <= 0)
        {
            Console.Write("Introduce un numero de ciclos mayor que cero: ");
            ciclos = int.Parse(Console.ReadLine() ?? "0");
        }
    }

    // Método para calcular el tiempo de un ciclo
    public void CalcularTiempoCiclo()
    {
        tiempoCiclo = tiempoTomar + tiempoTrasladar + tiempoSoltar;
    }

    // Método para simular los ciclos y acumular el tiempo
    public void SimularCiclos()
    {
        tiempoAcumulado = 0;

        for (int i = 1; i <= ciclos; i++)
        {
            tiempoAcumulado = tiempoAcumulado + tiempoCiclo;

            Console.WriteLine(
                "Ciclo " + i +
                ": tiempo acumulado = " +
                tiempoAcumulado + " s");
        }
    }

    // Método para mostrar los resultados finales
    public void MostrarResultados()
    {
        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine("Tiempo por ciclo: " + tiempoCiclo + " s");
        Console.WriteLine("Total de ciclos: " + ciclos);
        Console.WriteLine("Tiempo total de produccion: "
                          + tiempoAcumulado + " s");
    }
}

// Clase principal del programa
class Program
{
    static void Main()
    {
        // Creación del objeto
        BrazoRobotico brazo1 = new BrazoRobotico();

        // Llamada a los métodos
        brazo1.CapturarDatos();
        brazo1.CalcularTiempoCiclo();
        brazo1.SimularCiclos();
        brazo1.MostrarResultados();

        Console.WriteLine("\nPresiona una tecla para terminar.");
        Console.ReadKey();
    }
}
