namespace Program02;

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
        Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");

        int edad = 28;

        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
        Console.WriteLine("   Valor guardado: " + edad);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- VARIANTE 1: COMPRA DE FRUTAS ---");

        int manzanas = 5;
        int naranjas = 10;
        int totalFrutas = manzanas + naranjas;

        Console.WriteLine("Compré " + manzanas + " manzanas.");
        Console.WriteLine("Compré " + naranjas + " naranjas.");
        Console.WriteLine("Total de frutas en la bolsa: " + totalFrutas);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- VARIANTE 2: REPARTIENDO CARAMELOS ---");

        int totalCaramelos = 14;
        int cantidadAmigos = 4;

        int caramelosPorAmigo = totalCaramelos / cantidadAmigos;
        int sobran = totalCaramelos % cantidadAmigos;

        Console.WriteLine("Tenemos " + totalCaramelos + " caramelos para " + cantidadAmigos + " amigos.");
        Console.WriteLine("Cada uno se lleva: " + caramelosPorAmigo);
        Console.WriteLine("En la bolsa quedaron: " + sobran);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }
    
    static void Ejercicio1V3()
    {
        Console.WriteLine("--- VARIANTE 3: PLAN DE AHORRO ---");

        int ahorroPorMes = 2500;
        int mesesDelAnio = 12;
        int ahorroTotalAnual = ahorroPorMes * mesesDelAnio;

        Console.WriteLine("Si ahorro $" + ahorroPorMes + " por mes...");
        Console.WriteLine("Al final de los " + mesesDelAnio + " meses tendré: $" + ahorroTotalAnual);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- VARIANTE 4: PUNTOS DE JUEGO ---");

        int puntosIniciales = 1000;
        int bonusEncontrado = 500;
        int penalizacionPorDaniao = 200;

        int puntajeFinal = puntosIniciales + bonusEncontrado - penalizacionPorDaniao;

        Console.WriteLine("Empezaste con: " + puntosIniciales + " puntos.");
        Console.WriteLine("Sumaste un bonus de: " + bonusEncontrado);
        Console.WriteLine("Restaste por daño: " + penalizacionPorDaniao);
        Console.WriteLine("Puntaje final: " + puntajeFinal);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- VARIANTE 5: VIDAS EN EL JUEGO ---");

        int vidas = 3;
        Console.WriteLine("Tenés " + vidas + " vidas.");

        Console.WriteLine("¡Encontraste un corazón de vida!");
        vidas = vidas + 1;
        Console.WriteLine("Ahora tenés " + vidas + " vidas.");

        Console.WriteLine("Caíste en un pozo...");
        vidas = vidas - 1;
        Console.WriteLine("Te quedan " + vidas + " vidas.");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
