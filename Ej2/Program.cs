using EspacioCalculadora;
Calculadora calculadora = new Calculadora();
bool siguiente = true;
int opcion;
double suma = 0, resta = 0, producto = 0, division = 0;
while (siguiente)
{
    Console.WriteLine("");
    Console.WriteLine("1. sumar");
    Console.WriteLine("2. restar");
    Console.WriteLine("3. multiplicar");
    Console.WriteLine("4. dividir");
    Console.WriteLine("5. limpiar");
    Console.WriteLine("6. historial");
    Console.WriteLine("7. salir");
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.Write("Ingrese el término a sumar: ");
                if (double.TryParse(Console.ReadLine(), out suma))
                {
                    calculadora.Sumar(suma);
                }
                else
                {
                    Console.WriteLine("Error.");
                }
                break;
            case 2:
                Console.Write("Ingrese el término a restar: ");
                if (double.TryParse(Console.ReadLine(), out resta))
                {
                    calculadora.Restar(resta);
                }
                else
                {
                    Console.WriteLine("Error.");
                }
                break;
            case 3:
                Console.Write("Ingrese el término a Multiplicar: ");
                if (double.TryParse(Console.ReadLine(), out producto))
                {
                    calculadora.Multiplicar(producto);
                }
                else
                {
                    Console.WriteLine("Error.");
                }
                break;
            case 4:
                Console.Write("Ingrese el término a dividir: ");
                if (double.TryParse(Console.ReadLine(), out division))
                {
                    calculadora.Dividir(division);
                }
                else
                {
                    Console.WriteLine("Error.");
                }
                break;
            case 5:
                calculadora.Limpiar();
                break;
            case 6:
                calculadora.MostrarHistorial();
                break;
            case 7:
                siguiente = false;
                break;
            default:
                Console.WriteLine("Opción no válida. Intente nuevamente.");
                break;
        }
        Console.WriteLine($"Resultado actual: {calculadora.Resultado}");
    }
    else
    {
        Console.WriteLine("No es un valor valido.");
    }
}
