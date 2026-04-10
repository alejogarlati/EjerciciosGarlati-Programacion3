namespace Program05;

class Program
{
    static Random rnd = new Random(); // Instancia para generar números aleatorios (para determinar si los bool resultan true o false)

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
        Console.WriteLine("--- BLOQUE 4: VALORES LÓGICOS (SÍ / NO) ---");

        int numeroRandom = rnd.Next(0, 51);
        bool cursoCompletado = (numeroRandom % 2 == 0); // true si es par, false si es impar

        Console.WriteLine("6. TIPO LÓGICO (bool):");
        Console.WriteLine("   Solo puede ser 'true' o 'false'.");
        Console.WriteLine("   Número generado: " + numeroRandom);
        Console.WriteLine("   ¿El curso está completado?: " + cursoCompletado);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- VARIANTE 1: INTERRUPTOR DE LUZ ---");

        int numeroRandom = rnd.Next(0, 51);
        bool luzEncendida = (numeroRandom % 2 == 0);

        Console.WriteLine("Número generado: " + numeroRandom);
        Console.WriteLine("Has presionado el interruptor.");
        Console.WriteLine("¿La luz de la habitación está encendida?: " + luzEncendida);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- VARIANTE 2: SISTEMA DE ALARMA ---");

        int numPuerta = rnd.Next(0, 51);
        int numAlarma = rnd.Next(0, 51);
        bool puertaCerrada = (numPuerta % 2 == 0);
        bool alarmaActivada = (numAlarma % 2 == 0);

        Console.WriteLine("Puerta generada: " + numPuerta + " | Alarma generada: " + numAlarma);
        Console.WriteLine("Estado de la seguridad de la casa:");
        Console.WriteLine("¿Están las puertas cerradas?: " + puertaCerrada);
        Console.WriteLine("¿La alarma está sonando?: " + alarmaActivada);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }
    
    static void Ejercicio1V3()
    {
        Console.WriteLine("--- VARIANTE 3: COMPRAS ONLINE ---");

        int numCarrito = rnd.Next(0, 51);
        int numPago = rnd.Next(0, 51);
        bool carritoLleno = (numCarrito % 2 == 0);
        bool pagoRealizado = (numPago % 2 == 0);

        Console.WriteLine("Revisando el pedido...");
        Console.WriteLine("Carrito generado: " + numCarrito + " | Pago generado: " + numPago);
        Console.WriteLine("¿Hay productos en el carrito?: " + carritoLleno);
        Console.WriteLine("¿El cliente ya pagó?: " + pagoRealizado);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- VARIANTE 4: CLIMA ---");

        int numClima = rnd.Next(0, 51);
        bool estaLloviendo = (numClima % 2 == 0);
        bool llevarParaguas = estaLloviendo; // Si llueve, lo lleva

        Console.WriteLine("Clima generado: " + numClima);
        Console.WriteLine("Miro por la ventana...");
        Console.WriteLine("¿Está lloviendo?: " + estaLloviendo);
        Console.WriteLine("¿Debería llevar mi paraguas?: " + llevarParaguas);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- VARIANTE 5: CONFIGURACIONES MÓVILES ---");

        int numBateria = rnd.Next(0, 51);
        int numAvion = rnd.Next(0, 51);
        bool ahorroDeBateria = (numBateria % 2 == 0);
        bool modoAvion = (numAvion % 2 == 0);

        Console.WriteLine("Batería generada: " + numBateria + " | Avión generado: " + numAvion);
        Console.WriteLine("Estados del teléfono celular:");
        Console.WriteLine("Modo ahorro de energía: " + ahorroDeBateria);
        Console.WriteLine("Modo avión desactivado o activado: " + modoAvion);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
