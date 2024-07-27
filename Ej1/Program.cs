using System;
using System.Collections.Generic;
using EspacioTarea;
List<Tarea> pendientes = new List<Tarea>();
List<Tarea> realizadas = new List<Tarea>();
FuncionesTarea fc = new FuncionesTarea();
fc.crearTareas(pendientes);
int opcion;
do
{
    Console.WriteLine("1. Mostrar lista.");
    Console.WriteLine("2. Mover de pendientes a realizadas.");
    Console.WriteLine("3. Buscar por descripcion.");
    Console.WriteLine("4. Salir.");
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Lista Pendientes: ");
                fc.mostrarTareas(pendientes);
                Console.WriteLine("Lista Realizadas: ");
                fc.mostrarTareas(realizadas);
                break;
            case 2:
                fc.MoverTarea(pendientes, realizadas);
                break;
            case 3:
                Console.Write("Ingrese una descripcion para buscar en la lista. ");
                fc.BuscarTareasPorDescripcion(Console.ReadLine(), pendientes);
                break;
            case 4:
                Console.WriteLine("Saliendo...");
                break;
            default:
                break;
        }
    }
    else
    {
        Console.WriteLine("Error. valor invalido");
        Console.WriteLine("Intente otra vez...");
    }

} while (opcion!=4);
