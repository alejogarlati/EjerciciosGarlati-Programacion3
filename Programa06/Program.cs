namespace Program06;

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
        const string NOMBRE_APP = "GameMaster Pro";
        const string VERSION = "v1.0.2";
        const int EDAD_MINIMA = 18;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
        
        const int EDAD_CLIENTE = 20;
        const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
        Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
        Console.WriteLine("Acceso permitido: " + PUEDE_INGRESAR);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- VARIANTE 1: CONSTANTES MATEMÁTICAS ---");

        const double PI = 3.14159;
        double radio = 5.0;
        double area = PI * (radio * radio);

        Console.WriteLine("Valor de PI (Constante): " + PI);
        Console.WriteLine("Radio del círculo: " + radio);
        Console.WriteLine("Área calculada: " + area);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- VARIANTE 2: CONVERSIÓN DE MEDIDAS ---");

        const int CM_POR_METRO = 100;
        int metros = 3;
        int centimetros = metros * CM_POR_METRO;

        Console.WriteLine("Medida base equivalente: 1 metro = " + CM_POR_METRO + " cm (Constante)");
        Console.WriteLine("Tengo " + metros + " metros.");
        Console.WriteLine("En centímetros equivale a: " + centimetros + " cm.");

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }
    
    static void Ejercicio1V3()
    {
        Console.WriteLine("--- VARIANTE 3: LÍMITE DE VELOCIDAD ---");

        const int VELOCIDAD_MAXIMA = 80;
        int velocidadActual = 75;
        bool multado = velocidadActual > VELOCIDAD_MAXIMA;

        Console.WriteLine("Velocidad máxima permitida: " + VELOCIDAD_MAXIMA + " km/h (Constante)");
        Console.WriteLine("Vehículo circulando a: " + velocidadActual + " km/h");
        Console.WriteLine("¿Debería pagar multa?: " + multado);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- VARIANTE 4: CALENDARIO ---");

        const int DIAS_SEMANA = 7;
        const int MESES_ANIO = 12;
        int semanasVacaciones = 3;
        int diasVacaciones = semanasVacaciones * DIAS_SEMANA;

        Console.WriteLine("Días por semana: " + DIAS_SEMANA + " (Constante)");
        Console.WriteLine("Meses por año: " + MESES_ANIO + " (Constante)");
        Console.WriteLine("Duración de mis vacaciones (" + semanasVacaciones + " semanas): " + diasVacaciones + " días.");

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- VARIANTE 5: INTENTOS DE LOGIN ---");

        const int INTENTOS_MAXIMOS = 3;
        int intentosFallidos = 3;
        bool cuentaBloqueada = intentosFallidos >= INTENTOS_MAXIMOS;

        Console.WriteLine("Intentos permitidos por sistema: " + INTENTOS_MAXIMOS + " (Constante)");
        Console.WriteLine("Intentos fallidos actuales: " + intentosFallidos);
        Console.WriteLine("¿Cuenta bloqueada por seguridad?: " + cuentaBloqueada);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
