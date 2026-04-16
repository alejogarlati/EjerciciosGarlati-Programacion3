namespace Program07;

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
        // const decimal TASA_IVA = 0.21m;
        // const bool MODO_PRUEBA = false;
        // const char SIMBOLO_PESO = '$';

        // Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        // Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        // decimal precioBase = 1500.50m;
        // decimal impuestoCalculado = precioBase * TASA_IVA;
        // decimal total = precioBase + impuestoCalculado;

        // Console.WriteLine("\nDetalle de la compra:");
        // Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
        // Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        // Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

        // Console.WriteLine("\nPresiona ENTER para cerrar.");
        // Console.ReadLine();
    
        string[] nombres = new string[20];
        int[] edades = new int [20];

        for (int i = 0; i < 20; i++) {
            Console.WriteLine("Ingrese nombre");
            nombres[i] = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            edades[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 20; i++) {
            if (edades[i] > 30) {
                Console.WriteLine($"{nombres[i]} tiene {edades[i]} años. PASA!");
            } else {
                Console.WriteLine($"{nombres[i]} tiene {edades[i]} años. ¡A LA CASA!");
            }
        }    
    }

    static void Ejercicio1V1()
    {
        Console.WriteLine("--- VARIANTE 1: CÁLCULO DE PROPINA ---");

        const decimal PORCENTAJE_PROPINA = 0.10m;
        const char MONEDA = '$';
        
        decimal cuentaCena = 15000.00m;
        decimal propina = cuentaCena * PORCENTAJE_PROPINA;
        decimal total = cuentaCena + propina;

        Console.WriteLine("Consumo de la mesa: " + MONEDA + cuentaCena);
        Console.WriteLine("Propina sugerida (" + (PORCENTAJE_PROPINA * 100) + "%): " + MONEDA + propina);
        Console.WriteLine("Total a abonar: " + MONEDA + total);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V2()
    {
        Console.WriteLine("--- VARIANTE 2: DESCUENTO DE EMPLEADO ---");

        const decimal DESCUENTO_EMPLEADO = 0.30m;
        const bool ES_EMPLEADO_ACTIVO = true;

        decimal precioZapatillas = 85000.00m;
        decimal montoDescontado = precioZapatillas * DESCUENTO_EMPLEADO;
        decimal precioFinal = precioZapatillas - montoDescontado;

        Console.WriteLine("Estado de empleado activo: " + ES_EMPLEADO_ACTIVO);
        Console.WriteLine("Precio en vidriera: $" + precioZapatillas);
        Console.WriteLine("Ahorro por beneficio (" + (DESCUENTO_EMPLEADO * 100) + "%): -$" + montoDescontado);
        Console.WriteLine("Lo que paga la cajera: $" + precioFinal);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }
    
    static void Ejercicio1V3()
    {
        Console.WriteLine("--- VARIANTE 3: RECARGO POR TARJETA ---");

        const decimal RECARGO_CREDITO = 0.15m;
        const string METODO_PAGO = "Tarjeta de Crédito";

        decimal compra = 42000.00m;
        decimal interes = compra * RECARGO_CREDITO;
        decimal totalAPagar = compra + interes;

        Console.WriteLine("Pago mediante: " + METODO_PAGO);
        Console.WriteLine("Importe original de la compra: $" + compra);
        Console.WriteLine("Interés aplicado (" + (RECARGO_CREDITO * 100) + "%): +$" + interes);
        Console.WriteLine("Importe total en cuotas: $" + totalAPagar);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V4()
    {
        Console.WriteLine("--- VARIANTE 4: IMPUESTO DIGITAL ---");

        const decimal IMPUESTO_PAIS = 0.30m;
        const char SIMBOLO = '$';
        
        decimal suscripcionStreaming = 6000.00m;
        decimal percepcion = suscripcionStreaming * IMPUESTO_PAIS;
        decimal costoTarjeta = suscripcionStreaming + percepcion;

        Console.WriteLine("Membresía base de streaming: " + SIMBOLO + suscripcionStreaming);
        Console.WriteLine("Impuesto PAIS (" + (IMPUESTO_PAIS * 100) + "%): +" + SIMBOLO + percepcion);
        Console.WriteLine("Débito real en tu cuenta: " + SIMBOLO + costoTarjeta);

        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
    }

    static void Ejercicio1V5()
    {
        Console.WriteLine("--- VARIANTE 5: COMISIÓN DE VENTA ---");

        const decimal COMISION_PLATAFORMA = 0.13m;
        const bool ENVIO_GRATIS = true;

        decimal precioVenta = 20000.00m;
        decimal descuentoPorComision = precioVenta * COMISION_PLATAFORMA;
        decimal dineroRecibido = precioVenta - descuentoPorComision;

        Console.WriteLine("El envío del producto fue gratuito: " + ENVIO_GRATIS);
        Console.WriteLine("Vendiste un producto a: $" + precioVenta);
        Console.WriteLine("Comisión de la plataforma (" + (COMISION_PLATAFORMA * 100) + "%): -$" + descuentoPorComision);
        Console.WriteLine("Dinero neto acreditado en tu cuenta: $" + dineroRecibido);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
}
