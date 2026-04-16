namespace ArraysEjercicio1;

class Program
{
    static void SiguienteEjercicio() {
        Console.WriteLine("Pulsa cualquier tecla para pasar al siguiente ejemplo.");
        Console.ReadKey();
        Console.Clear();
    }
    static void Main(string[] args)
    {
    Ejercicio1V0();
    SiguienteEjercicio();
    Ejercicio1V1();
    SiguienteEjercicio();
    Ejercicio1V2();
    SiguienteEjercicio();
    Ejercicio1V3();
    SiguienteEjercicio();
    Ejercicio1V4();
    SiguienteEjercicio();
    Ejercicio1V5();
    }

    static void Ejercicio1V0()
    {
        // EJERCICIO INICIAL --------------------------------------------------------------------------->
        
        Console.WriteLine("---EJERCICIO INICIAL: FUNDAMENTOS DE ARRAYS---");

        int[] numeros = new int[3];

        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;

        Console.WriteLine("Valor en índice 0: " + numeros[0]);
        Console.WriteLine("Valor en índice 1: " + numeros[1]);
        Console.WriteLine("Valor en índice 2: " + numeros[2]);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- GASTOS RECIENTES ---");

        double[] gastos = new double[3];
        gastos[0] = 2500.50;
        gastos[1] = 1300.00;
        gastos[2] = 8400.75;

        for(int i = 0; i < gastos.Length; i++)
        {
            Console.WriteLine($"Gasto {i + 1}: ${gastos[i]}");
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- SERIES POR VER ---");

        string[] series = { "Breaking Bad", "The Office", "Stranger Things" };

        foreach(string serie in series)
        {
            Console.WriteLine("Serie en lista: " + serie);
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V3()
    {
        Console.WriteLine("--- NOTAS DEL TRIMESTRE ---");

        int[] notas = new int[3];
        
        Console.Write("Ingresa la primera nota: ");
        notas[0] = int.Parse(Console.ReadLine() ?? "0");
        
        Console.Write("Ingresa la segunda nota: ");
        notas[1] = int.Parse(Console.ReadLine() ?? "0");
        
        Console.Write("Ingresa la tercera nota: ");
        notas[2] = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"\nPromedio general: {(notas[0] + notas[1] + notas[2]) / 3.0:F2}");

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- CANTIDAD DE PASOS DIARIOS ---");

        int[] pasos = { 5400, 8100, 10200, 7500, 9300 };
        int totalPasos = 0;

        for (int i = 0; i < pasos.Length; i++)
        {
            Console.WriteLine($"Día {i + 1}: {pasos[i]} pasos");
            totalPasos += pasos[i];
        }

        Console.WriteLine($"\nTotal semanal: {totalPasos} pasos");
        
        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- TOP VIDEOJUEGOS ---");

        string[] juegos = new string[3];
        juegos[0] = "Minecraft";
        juegos[1] = "The Legend of Zelda";
        juegos[2] = "Hollow Knight";

        for (int i = 0; i < juegos.Length; i++)
        {
            Console.WriteLine($"Puesto {i + 1}: {juegos[i]}");
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

}
