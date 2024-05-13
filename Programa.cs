using Guia;

namespace Guia4
{
    class Programa
    {

        static void Main(string[] args)
        {
            /*En el programa principal (Program.cs), crea instancias de la clase Universidad.
             * Agrega varios alumnos a la universidad con sus respectivas calificaciones y números de carnet. */
             
            Universidad universidad = new Universidad();
            Alumno alumno1 = new Alumno("Benett", 18, Carreras.Ingeniería, "2023-1080U");
            alumno1.Calificaciones = new List<double> { 70, 65.88, 80 };

            alumno1.DatosDeAlumno();
            alumno1.ObtenerNumeroDeCarnet("2023-1980");
            universidad.AgregarAlumnos(alumno1);


 
            Alumno alumno2 = new Alumno("Valeska", 18, Carreras.AreaDeLaSalud, "2022-4568O");
            alumno2.Calificaciones = new List<double> { 80, 80, 90 };

            alumno2.DatosDeAlumno();
            universidad.AgregarAlumnos(alumno2);


           
            Alumno alumno3 = new Alumno("Eduardo", 20, Carreras.Negocios, "2021-0001P");
            alumno3.Calificaciones = new List<double> { 100, 80.4, 90.99 };

            alumno3.DatosDeAlumno();
            universidad.AgregarAlumnos(alumno3);



            //Muestra la lista de alumnos con sus detalles, incluyendo promedio de calificaciones y estado de aprobación.    
            List<Alumno> listaAlumnos = universidad.ObtenerListaDeAlumnos();
            foreach(var alumno in listaAlumnos)
            {
                Console.WriteLine($"Nombre {alumno.Nombre}, Edad: {alumno.Edad}, Carrera{alumno.CarreraEstudiante}, Promedio de califaciones {alumno.CalcularPromedioCalifacionesDelAlumno()}, Estado de aprobación: {alumno.EstadoDeAprobacion()}, Número de Carnet {alumno.NumeroCarnet}. ");
            }


        }
    }
}
