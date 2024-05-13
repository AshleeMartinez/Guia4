using Guia;


namespace Guia4
{
    class Universidad
    {
        //Lista de Alumnos
        public List<Alumno> listaDeAlumnos;
        //Constructor 

        public Universidad()
        {
            listaDeAlumnos = new List<Alumno>();
        }

        //Método estático para agregar un nuevo alumnos a la lista de la u
       public void AgregarAlumnos(Alumno alumno)
        {
            listaDeAlumnos.Add(alumno);
        }

        //Metodo para obtener la lista de todos los alumnos registrados.
        public List<Alumno> ObtenerListaDeAlumnos() 
        {
        return listaDeAlumnos;
        }


    }
}
