namespace Program03;

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
        Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

        double estatura = 1.75;
        Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + estatura + " metros");

        decimal precioProducto = 199.99m;
        Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
        Console.WriteLine("   Valor guardado: $" + precioProducto);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- VARIANTE 1: COMPRA DE SUPERMERCADO ---");

        decimal leche = 1200.50m;
        decimal pan = 850.25m;
        decimal total = leche + pan;

        Console.WriteLine("Leche: $" + leche);
        Console.WriteLine("Pan: $" + pan);
        Console.WriteLine("Total a pagar: $" + total);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- VARIANTE 2: PROMEDIO DE NOTAS ---");

        double nota1 = 8.5;
        double nota2 = 7.0;
        double nota3 = 9.2;
        double promedio = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("Notas: " + nota1 + ", " + nota2 + " y " + nota3);
        Console.WriteLine("Promedio final: " + promedio);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }
    
    static void Ejercicio1V3()
    {
        Console.WriteLine("--- VARIANTE 3: CASA DE CAMBIO ---");

        decimal dolares = 100.0m;
        decimal tipoCambio = 1125.50m;
        decimal pesos = dolares * tipoCambio;

        Console.WriteLine("Cambiando US$" + dolares);
        Console.WriteLine("Tipo de cambio: $" + tipoCambio);
        Console.WriteLine("Recibís: $" + pesos + " pesos");

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- VARIANTE 4: ÁREA DE UN CÍRCULO ---");

        double radio = 4.5;
        double pi = 3.14159;
        double area = pi * (radio * radio);

        Console.WriteLine("Radio: " + radio);
        Console.WriteLine("La superficie del círculo es: " + area);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- VARIANTE 5: DESCUENTO EN TIENDA ---");

        decimal precioOriginal = 15400.0m;
        decimal porcentajeDescuento = 0.20m;
        decimal descuento = precioOriginal * porcentajeDescuento;
        decimal precioFinal = precioOriginal - descuento;

        Console.WriteLine("Precio original: $" + precioOriginal);
        Console.WriteLine("Descuento del 20%: $" + descuento);
        Console.WriteLine("Precio final con descuento: $" + precioFinal);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
