using Guia4;

namespace Guia
{
    public class Alumno{
        public string Nombre { get; set; }  
        public int Edad {  get; set; }
        public Carreras CarreraEstudiante { get; set; }

        public List <double> Calificaciones { get; set; }
        public string NumeroCarnet { get; set; }


        public Alumno(string nombre, int edad, Carreras carrera, string numeroCarnet)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.CarreraEstudiante = carrera;
            this.NumeroCarnet = numeroCarnet;
            Calificaciones = new List<double>();
        }


        public void DatosDeAlumno()
        {
            Console.WriteLine($"El Alummno cuyo nombre es: {Nombre},tiene {Edad} años, que pertenece a la carrera de {CarreraEstudiante}, cuyo carnet es {NumeroCarnet}, con califaciones de: ");
            foreach (var calificacion in Calificaciones) //Para mostrar califaciones en el formato correcto ya que es una lista, entiendo de esta manera que las listas son especies de arreglos asi que por eso el foreach
            {
                Console.Write($"{calificacion} ");
            }
            Console.WriteLine();

        }

        //Calcular el promedio de las calificaciones del alumno.
        public double CalcularPromedioCalifacionesDelAlumno()
        {
            if(Calificaciones.Count > 0)
            {
                return 0; //Si no hay califaciones, el prom e 0
            }

            double sumaCalifaciones = 0;
            foreach(var calificaciones in Calificaciones)
            {
                sumaCalifaciones += calificaciones;
            }
            return sumaCalifaciones/Calificaciones.Count;
        }

        //Determinar el estado de aprobación del alumno (aprobado si el promedio >= 60, reprobado si el promedio < 60).
        public string EstadoDeAprobacion()
        {
            double prom = CalcularPromedioCalifacionesDelAlumno();
            if(prom >=60)
            {
                return "Aprobado";
            }
            else if(prom <60)
            {
                return "Reprobado";
            }
            return "";
        }

        //Asignar y obtener el número de carnet del alumno.  

        public void ObtenerNumeroDeCarnet(string numeroDeCarnet)
        {
            NumeroCarnet = numeroDeCarnet;
        }

    }
}

