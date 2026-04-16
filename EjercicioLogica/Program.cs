Console.WriteLine("------------------------------------------");
Console.WriteLine("       SISTEMA DE INGRESO - BOLICHE       ");
Console.WriteLine("------------------------------------------\n");

string[] nombres = new string[20];
int[] edades = new int[20];

// 1. Ingreso de datos
for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"\n> Cliente #{i + 1}");
    
    Console.Write("  Ingrese nombre: ");
    nombres[i] = Console.ReadLine() ?? string.Empty;
    
    Console.Write("  Ingrese edad: ");
    int.TryParse(Console.ReadLine(), out edades[i]);
}

Console.Clear();
Console.WriteLine("------------------------------------------");
Console.WriteLine("          RESULTADOS DE ACCESO            ");
Console.WriteLine("------------------------------------------\n");

// 2. Evaluación de edades
for (int i = 0; i < 20; i++)
{
    if (edades[i] > 30)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" [ ✔ ] {nombres[i]} tiene {edades[i]} años. PASA!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($" [ X ] {nombres[i]} tiene {edades[i]} años. ¡A LA CASA!");
    }
    Console.ResetColor();
}

Console.WriteLine("\nPresione ENTER para salir...");
Console.ReadLine();
