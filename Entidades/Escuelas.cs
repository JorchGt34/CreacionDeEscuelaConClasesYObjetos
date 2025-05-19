using CoreEscuela.Util;
using Etapa1;
using Etapa1.Entidades;
using static System.Console;

namespace CoreEscuela.Entidades
{
    public class Escuelas: ObjetoEscuelaClase, ILugar
    {
        public int AñoDeCreación { get; set; }
        public string País { get; set; }
        public string Ciudad { get; set; }
        public string Dirección { get; set; }
        public TiposDeEscuelas TipoEscuela{ get; set; }
        //public Escuela(string nombre, int año)
        //{
        //    this.nombre = nombre; //Donde this es miembro de la clase
        //    AñoDeCreación = año;
        //} Esta es la manera de hacer la asignación de los valores de la misma manera que la función de abajo
        public List<Cursos> Cursos { get; set; } //Ahora se inicia una lista genrica de cursos
        public Escuelas(string nombre, int año)
        {
            (Nombre, AñoDeCreación) = (nombre, año);
        }
        public Escuelas(string nombre, 
                        int año, 
                        TiposDeEscuelas tipo, 
                        string país = "", 
                        string ciudad = "")
        {
            (Nombre, AñoDeCreación) = (nombre, año);
            País = país;
            Ciudad = ciudad;
            TipoEscuela = tipo;
        }

        public override string ToString()//ToString era un objeto que imprime texto usando Console.WriteLine, haciendo un override a este objeto cambiamos lo que se imprime al usal un objeto
        {
            //Para poner caracteres especiales dentro de una cadena de texto se usa "\" seguido del caracter. También se puede usar System.Enviroment se obtiene el valor equivalente al sistema operativo.
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine}País: {País}, Ciudad: {Ciudad}";
        }
        //Aqui se implementa la herencia de una interfaz llamada ILugar, donde 
        public void LimpiarLugar()
        {
            Printer.DibujarLinea();
            WriteLine("Limpiando escuela...");
            foreach (var curso in Cursos)
            {
                curso.LimpiarLugar();
            }
            WriteLine($"Escuela {Nombre} limpio");
        }
    }
}