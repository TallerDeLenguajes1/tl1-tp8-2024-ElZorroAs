namespace EspacioCalculadora
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar
    }
    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;

        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }
        public double Resultado
        {
            get { return resultadoAnterior; }
        }

        public double NuevoValor
        {
            get { return nuevoValor; }
        }
        public TipoOperacion OperacionTipo
        {
            get { return operacion; }
        }
    }
    public class Calculadora
    {
        private double dato;
        private List<Operacion> historial;
        public Calculadora()
        {
            dato = 0;
            historial = new List<Operacion>();
        }
        public void Sumar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Suma));
            dato += termino;
        }
        public void Restar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Resta));
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Multiplicacion));
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                historial.Add(new Operacion(dato, termino, TipoOperacion.Division));
                dato /= termino;
            }
            else
            {
                Console.WriteLine("Error no se puede dividir por cero.");
            }

        }
        public void Limpiar()
        {
            historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
            dato = 0;
        }
        public double Resultado
        {
            get { return dato; }
        }
        public List<Operacion> Historial
        {
            get { return historial; }
        }
        public void MostrarHistorial()
        {
            Console.WriteLine("Historial de Operaciones:");
            foreach (var operacion in historial)
            {
                Console.WriteLine($"Operación: ({operacion.Resultado}), {operacion.OperacionTipo}, ({operacion.NuevoValor})");
            }
        }
    }
}