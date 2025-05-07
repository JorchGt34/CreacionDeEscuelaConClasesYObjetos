using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {

        }
        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposDeEscuela.Preparatoria, ciudad: "Bogotá");
            Escuela.Cursos = new List<Curso>(){
                new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "202", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "303", Jornada = TiposJornada.Mañana},
                new Curso(){Nombre = "401", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "501", Jornada = TiposJornada.Tarde},
                new Curso(){Nombre = "502", Jornada = TiposJornada.Tarde}
            };
        }
    }
}