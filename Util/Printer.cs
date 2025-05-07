using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer //Donde static no permite crear objetos pero se usa como un objeto por si misma
    {
        //Ya que todo en C# es un objeto, podemos usar metodos en los objetos que utilicemos
        public static void DibujarLinea(int size = 10)
        {
            WriteLine("".PadLeft(size, '='));
        }
        public static void DibujarTitulo(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }
    }
}