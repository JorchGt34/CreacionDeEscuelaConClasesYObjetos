namespace Etapa1.Entidades
{
    //Al agregar ": ObjetoEscuelaClase" se heredan las prpiedades de ObjetoEscuelaClase
    public class Alumnos: ObjetoEscuelaClase
    {
        //Se debe de inicializar una lista para poder empezar a poner ddatos en ella
        public List<Evaluaciones>? Evaluacion { get; set;} = new List<Evaluaciones>();
    }
}