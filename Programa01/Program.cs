namespace Program01;

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
        
        Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

        // 1. Entrada de Texto (Simple)
        Console.Write("Por favor, ingresa tu nombre: ");
        string? nombre = Console.ReadLine();

        // 2. Entrada de Números (Requiere Conversión)
        Console.Write("Ingresa tu edad: ");
        string? edadTexto = Console.ReadLine();
        int? edad = int.Parse(edadTexto ?? ""); // Convertimos el texto a número entero

        // 3. Entrada de Decimales (Precios o Medidas)
        Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
        double? estatura = double.Parse(Console.ReadLine() ?? ""); // Conversión directa en una línea

        // 4. Mostrar los resultados procesados
        Console.WriteLine("\n--- PERFIL CREADO ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad el próximo año: " + (edad + 1)); // Operación matemática
        Console.WriteLine("Estatura: " + estatura + " metros");

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        // VARIANTE 1 ---------------------------------------------------------------------------------->
            
        Console.WriteLine("--- SISTEMA DE REGISTRO DE AUTOMOTORES ---");

        // 1. Entrada de Texto (Simple)
        Console.Write("Por favor, ingresa la marca del automotor: ");
        string? marca = Console.ReadLine();

        // 2. Entrada de Números (Requiere Conversión)
        Console.Write("Ingresa el modelo del automotor: ");
        string? modelo = Console.ReadLine();
        Console.Write("Ingresa el año del automotor: ");
        int? año = int.Parse(Console.ReadLine() ?? ""); // Convertimos el texto a número entero

        // 3. Entrada de Decimales (Precios o Medidas)
        Console.Write("Ingresa el precio del automotor: ");
        double? precio = double.Parse(Console.ReadLine() ?? ""); // Conversión directa en una línea

        // 4. Mostrar los resultados procesados
        Console.WriteLine("\n--- FICHA DEL AUTOMOTOR ---");
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Año: " + año);
        Console.WriteLine("Precio: " + precio);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        // VARIANTE 2 ---------------------------------------------------------------------------------->
            
        Console.WriteLine("--- SISTEMA DE REGISTRO WEB ---");

        // 1. Entrada de Texto (Simple)
        Console.Write("Por favor, ingresa el nombre del usuario: ");
        string? nombre = Console.ReadLine();

        // 2. Entrada de Números (Requiere Conversión)
        Console.Write("Ingresa el email del usuario: ");
        string? email = Console.ReadLine();
        Console.Write("Ingresa la edad del usuario: ");
        int? edad = int.Parse(Console.ReadLine() ?? ""); // Convertimos el texto a número entero

        // 3. Entrada de Decimales (Precios o Medidas)
        Console.Write("Ingresá el DNI del usuario: ");
        int? dni = int.Parse(Console.ReadLine() ?? "");

        // 4. Mostrar los resultados procesados
        Console.WriteLine("\n--- FICHA DEL USUARIO ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("DNI: " + dni);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }
    
    static void Ejercicio1V3()
    {
        // VARIANTE 3--------------------------------------------------------------------------------->
            
        Console.WriteLine("--- SISTEMA DE REGISTRO DE IMPUESTOS ---");

        // 1. Entrada de Texto (Simple)
        Console.Write("Por favor, ingresa el nombre del contribuyente: ");
        string? nombre = Console.ReadLine();

        // 2. Entrada de Números (Requiere Conversión)
        Console.Write("Ingresa el email del contribuyente: ");
        string? email = Console.ReadLine();
        Console.Write("Ingresa el resultado mensual del contribuyente: ");
        double? resultadoMensual = double.Parse(Console.ReadLine() ?? ""); // Convertimos el texto a número entero

        // 3. Entrada de Decimales (Precios o Medidas)
        Console.Write("Ingresá el DNI del contribuyente: ");
        int? dni = int.Parse(Console.ReadLine() ?? "");

        // 4. Mostrar los resultados procesados
        Console.WriteLine("\n--- FICHA DEL CONTRIBUYENTE ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Email: " + email);
        Console.WriteLine("Resultado Mensual: " + resultadoMensual);
        Console.WriteLine("Resultado Anual proyectado: " + resultadoMensual * 12);
        Console.WriteLine("IVA proyectado: " + resultadoMensual * 12 * 0.21);
        Console.WriteLine("Ganancias proyectadas: " + resultadoMensual * 12 * 0.35);
        Console.WriteLine("Total a pagar: " + (resultadoMensual * 12 * 0.21 + resultadoMensual * 12 * 0.35));

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        // VARIANTE 4--------------------------------------------------------------------------------->
            
        Console.WriteLine("--- SISTEMA DE REGISTRO DE MASCOTA ---");

        Console.Write("Ingresa el nombre de la mascota: ");
        string? nombre = Console.ReadLine();

        Console.Write("Ingresa la edad de la mascota: ");
        int? edad = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Ingresa la raza de la mascota: ");
        string? raza = Console.ReadLine();

        Console.Write("Ingresa el peso de la mascota: ");
        double? peso = double.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("La mascota tiene " + edad + " años, pesa " + peso + " kg y es de raza " + raza);
        Console.WriteLine("Según el tratamiento indicado, deberá recibir " + (peso * 1.5) + " pastillas de desparasitación.");
        Console.WriteLine("El costo total del tratamiento es de $" + (peso * 1.5 * 1500) + ". ($1500 es el costo de cada pastilla)");

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        // VARIANTE 5--------------------------------------------------------------------------------->
            
        Console.WriteLine("--- CREÁ TU PERSONAJE DE ROL ---");

        Console.Write("Ingresa el nombre de tu personaje: ");
        string? nombre = Console.ReadLine();

        Console.Write("Ingresa la edad de tu personaje: ");
        int? edad = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Ingresa la raza de tu personaje (Elfo, Humano, Enano, Orco, Vampiro): ");
        string? raza = Console.ReadLine();

        Console.Write("Ingresa la clase de tu personaje (Guerrero, Mago, Arquero, Ladrón): ");
        string? clase = Console.ReadLine();

        Console.Write("Elige el arma inicial de tu personaje (Espada, Arco, Bastón, Daga): ");
        string? arma = Console.ReadLine();

        Console.Write("Elige el favor de los dioses (Anubis, Ra, Osiris, Horus): ");
        string? favor = Console.ReadLine();

        Console.WriteLine("\n--- FICHA DEL PERSONAJE ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Raza: " + raza);
        Console.WriteLine("Clase: " + clase);
        Console.WriteLine("Arma: " + arma);
        Console.WriteLine("Favor de los dioses: " + favor);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

}
