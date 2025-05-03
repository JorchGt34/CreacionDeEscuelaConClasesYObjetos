using System.Reflection.Metadata.Ecma335;

namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre {
            get { return "El nombre de la escuela es: " + nombre; } //Si de afuera se pide el nombre, se regresa el valor actual del nombre
            set { nombre = value.ToUpper(); } //Si se va a asignar un valor a nombre, la propiedad nombre recibira el valor que se le asigne.
            //En este caso los valores que entren siempre serán mayúsculas
        }

        public int AñoDeCreación { get; set; }
        public string País { get; set; }
        public string Ciudad { get; set; }
        public TiposDeEscuela TipoEscuela{ get; set; }
        //public Escuela(string nombre, int año)
        //{
        //    this.nombre = nombre; //Donde this es miembro de la clase
        //    AñoDeCreación = año;
        //} Esta es la manera de hacer la asignación de los valores de la misma manera que la función de abajo

        public Escuela(string nombre, int año)
        {
            (Nombre, AñoDeCreación) = (nombre, año);
        }
        public Escuela(string nombre, 
                        int año, 
                        TiposDeEscuela tipo, 
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
            return $"Nombre: \"{nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine}País: {País}, Ciudad: {Ciudad}";
        }
    }
}