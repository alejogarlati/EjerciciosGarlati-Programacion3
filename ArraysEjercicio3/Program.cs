namespace ArraysEjercicio3;

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
        
        Console.WriteLine("--- EJERCICIO INICIAL 3: USO DE .LENGTH Y BUCLE FOR ---");

        int[] edades = { 15, 22, 30, 18, 25 };

        int cantidadElementos = edades.Length;
        Console.WriteLine("El arreglo tiene " + cantidadElementos + " elementos.");
        Console.WriteLine("-------------------------------------");

        for(int i = 0; i < edades.Length; i++)
        {
            Console.WriteLine("Índice " + i + ": La edad es " + edades[i]);
        }
        
        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- LISTA DE INVITADOS ---");

        string[] invitados = { "Juan", "María", "Pedro", "Ana", "Luis" };
        
        Console.WriteLine("Total de invitados: " + invitados.Length);
        Console.WriteLine("-------------------------------------");
        
        for(int i = 0; i < invitados.Length; i++)
        {
            Console.WriteLine($"Invitado #{i + 1}: {invitados[i]}");
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- NOTAS DE EXÁMENES ---");

        int[] notas = { 8, 9, 6, 10, 7 };
        
        Console.WriteLine("Exámenes corregidos: " + notas.Length);
        Console.WriteLine("-------------------------------------");
        
        for(int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Examen {i + 1} - Nota obtenida: {notas[i]}");
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V3()
    {
        Console.WriteLine("--- TEMPERATURAS REGISTRADAS ---");

        double[] temperaturas = { 25.5, 26.2, 24.8, 28.1, 27.5 };
        
        Console.WriteLine("Cantidad de días registrados: " + temperaturas.Length);
        Console.WriteLine("-------------------------------------");
        
        for(int i = 0; i < temperaturas.Length; i++)
        {
            Console.WriteLine($"Día {i + 1}: {temperaturas[i]}°C");
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- BANDEJA DE ENTRADA ---");

        string[] mensajes = { "Oferta de trabajo", "Promo de supermercado", "Aviso de pago de luz" };
        
        Console.WriteLine("Tienes " + mensajes.Length + " mensajes nuevos en la bandeja.");
        Console.WriteLine("-------------------------------------");
        
        for(int i = 0; i < mensajes.Length; i++)
        {
            Console.WriteLine($"Mensaje índice {i}: '{mensajes[i]}'");
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- MINUTOS DE ENTRENAMIENTO ---");

        int[] minutos = { 30, 45, 40, 50, 60, 45, 30 };
        
        Console.WriteLine("Total de sesiones registradas: " + minutos.Length);
        Console.WriteLine("-------------------------------------");
        
        for(int i = 0; i < minutos.Length; i++)
        {
            Console.WriteLine($"Sesión del día {i + 1}: {minutos[i]} min");
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

}
