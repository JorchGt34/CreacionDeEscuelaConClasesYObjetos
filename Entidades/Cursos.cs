using CoreEscuela.Util;
using Etapa1;
using Etapa1.Entidades;
using static System.Console;

namespace CoreEscuela.Entidades
{
    public class Cursos: ObjetoEscuelaClase, ILugar
    {
        public TiposJornadas Jornada { get; set; }
        public List<Asignaturas> Asignaturas { get; set; }
        public List<Alumnos> Alumno { get; set; }
        public string Dirección { get; set; }
        public void LimpiarLugar()
        {
            Printer.DibujarLinea();
            WriteLine("Limpiando Establecimiento...");
            WriteLine($"Curso {Nombre} limpio");
        }
    }
}