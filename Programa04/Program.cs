namespace Program04;

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
        Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

        string nombre = "Ana López";
        Console.WriteLine("4. TIPO TEXTO (string):");
        Console.WriteLine("   Valor guardado: " + nombre);

        char inicialNombre = 'A';
        Console.WriteLine("\n5. TIPO CARÁCTER (char):");
        Console.WriteLine("   Valor guardado: '" + inicialNombre + "'");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- VARIANTE 1: NOMBRE COMPLETO ---");

        string nombre = "Alejo";
        string apellido = "Garlati";
        string nombreCompleto = nombre + " " + apellido;

        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("Ficha: " + nombreCompleto);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- VARIANTE 2: INICIALES ---");

        char inicialNombre = 'A';
        char inicialApellido = 'G';

        Console.WriteLine("La primera letra del nombre es: " + inicialNombre);
        Console.WriteLine("La primera letra del apellido es: " + inicialApellido);
        Console.WriteLine("Iniciales: " + inicialNombre + "." + inicialApellido + ".");

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }
    
    static void Ejercicio1V3()
    {
        Console.WriteLine("--- VARIANTE 3: GENERADOR DE EMAILS ---");

        string usuario = "alejo.garlati";
        string dominio = "@miuniversidad.edu";
        string emailCompleto = usuario + dominio;

        Console.WriteLine("Usuario: " + usuario);
        Console.WriteLine("Dominio: " + dominio);
        Console.WriteLine("Email generado: " + emailCompleto);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- VARIANTE 4: CÓDIGO DE PRODUCTO ---");

        char seccion = 'F';
        int pasillo = 12;
        string codigo = seccion + "-" + pasillo;

        Console.WriteLine("Sección: " + seccion);
        Console.WriteLine("Pasillo: " + pasillo);
        Console.WriteLine("Ubicación del producto: " + codigo);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- VARIANTE 5: ETIQUETA DE PRECIO ---");

        char simboloMoneda = '$';
        string montoTexto = "25.400";
        string etiqueta = simboloMoneda + montoTexto;

        Console.WriteLine("Símbolo: " + simboloMoneda);
        Console.WriteLine("Monto: " + montoTexto);
        Console.WriteLine("Precio final: " + etiqueta);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
