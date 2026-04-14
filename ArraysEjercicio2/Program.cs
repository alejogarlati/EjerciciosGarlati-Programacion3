namespace ArraysEjercicio2;

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
        
        Console.WriteLine("--- EJERCICIO INICIAL 2: INICIALIZACIÓN DIRECTA Y FOREACH");

        string[] frutas = { "Manzana", "Banana", "Uva", "Naranja" };

        Console.WriteLine("Lista de frutas usando foreach:");

        foreach(string fruta in frutas)
        {
            Console.WriteLine("- " + fruta);
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- TAREAS DEL HOGAR ---");

        string[] tareas = { "Lavar los platos", "Sacar la basura", "Barrer el piso", "Limpiar los vidrios" };

        foreach(string tarea in tareas)
        {
            Console.WriteLine("- Pendiente: " + tarea);
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- COMPONENTES DE PC ---");

        string[] componentes = { "Procesador Ryzen 5", "Memoria RAM 16GB", "Placa de Video RX 7600", "Disco M.2 1TB" };

        foreach(string componente in componentes)
        {
            Console.WriteLine("- Agregado al carrito: " + componente);
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V3()
    {
        Console.WriteLine("--- PRECIOS DE SUSCRIPCIONES ---");

        double[] precios = { 1500.50, 4999.99, 1200.00, 850.25 };

        foreach(double precio in precios)
        {
            Console.WriteLine("- Costo mensual: $" + precio);
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- EDADES DEL EQUIPO ---");

        int[] edades = { 21, 19, 25, 23, 18, 26 };

        foreach(int edad in edades)
        {
            Console.WriteLine("- Jugador registrado con edad: " + edad + " años");
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- RUTINA DE GIMNASIO ---");

        string[] dias = { "Lunes: Pecho y Tríceps", "Miércoles: Espalda y Bíceps", "Viernes: Piernas y Hombros" };

        foreach(string dia in dias)
        {
            Console.WriteLine("- " + dia);
        }

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

}
