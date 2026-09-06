using System;
namespace LibroCalificacionesModificadores
{
    public class LibroCalificaciones
    {
        private string nombreCurso;
        public LibroCalificaciones(string nombre)
        {
            nombreCurso = nombre;
        }
        public string NombreCurso
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        }
        public void MostrarMensaje()
        {
            Console.WriteLine("Bienvenido al libro de calificaciones para: \n{0}!", NombreCurso);
        }
    }
}