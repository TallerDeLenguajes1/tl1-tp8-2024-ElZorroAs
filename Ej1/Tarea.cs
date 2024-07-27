using System;
namespace EspacioTarea
{

    public class Tarea
    {

        private int idTarea;
        public int IdTarea { get => idTarea; set => idTarea = value; }
        private int duracion;
        public int Duracion { get => duracion; set => duracion = value; }
        private string descripcion;
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Tarea(int idTarea, int duracion, string descripcion)
        {
            this.idTarea = idTarea;
            this.duracion = duracion;
            this.descripcion = descripcion;
        }

        public Tarea()
        {
            descripcion=" ";
        }
        public void MostrarTarea()
        {
            Console.ForegroundColor = ConsoleColor.Green; // Cambia el color del texto a verde
            Console.WriteLine($"ID de Tarea: {IdTarea}, Duración: {Duracion}, Descripción: {Descripcion}");
            Console.ResetColor(); // Restablece el color del texto al predeterminado
        }
    }
    public class FuncionesTarea
    {
        //1. Cree aleatoriamente N tareas pendientes
        public void crearTareas(List<Tarea> pendientes)
        {
            Random rand = new Random();
            int n = rand.Next(10, 101);
            for (int i = 0; i < n; i++)
            {
                pendientes.Add(new Tarea
                {
                    IdTarea = i,
                    Descripcion = $"Tarea {i}",
                    Duracion = rand.Next(10, 101)
                });
            }
        }
        public void mostrarTareas(List<Tarea> lista)
        {
            foreach (Tarea i in lista)
            {
                i.MostrarTarea();
            }
        }
        //2. Desarrolle una interfaz para mover las tareas pendientes a realizadas.
        public void MoverTarea(List<Tarea> pendientes, List<Tarea> realizadas)
        {
            // Solicita al usuario que ingrese el ID de la tarea
            Console.Write("Por favor, ingresa el ID de la tarea que deseas mover: ");
            int idTarea;
            if (int.TryParse(Console.ReadLine(), out idTarea))
            {
                // Busca la tarea con el ID proporcionado en la lista de tareas pendientes
                Tarea tarea = pendientes.FirstOrDefault(t => t.IdTarea == idTarea);

                // Si se encontró la tarea, la mueve a la lista de tareas realizadas
                if (tarea != null)
                {
                    pendientes.Remove(tarea);
                    realizadas.Add(tarea);
                }
                else
                {
                    Console.WriteLine($"No se encontró ninguna tarea pendiente con el ID {idTarea}.");
                }
            }
            else
            {
                Console.WriteLine("El ID ingresado no es válido. Por favor, intenta de nuevo.");
            }
        }

        //3. Desarrolle una interfaz para buscar tareas pendientes por descripción
        public void BuscarTareasPorDescripcion(string descripcion, List<Tarea>pendientes)
        {
            List<Tarea> tareasEncontradas = pendientes.Where(t => t.Descripcion == descripcion).ToList();

            if (tareasEncontradas.Count > 0)
            {
                Console.WriteLine($"Se encontraron {tareasEncontradas.Count} tareas con la descripción \"{descripcion}\":");
                foreach (Tarea tarea in tareasEncontradas)
                {
                    tarea.MostrarTarea();
                }
            }
            else
            {
                Console.WriteLine($"No se encontraron tareas con la descripción \"{descripcion}\".");
            }
        }

    }
}