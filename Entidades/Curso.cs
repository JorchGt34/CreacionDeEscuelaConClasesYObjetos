using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa1.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public Curso()
        {
            //Esto crea un Id aleatorio pero unico
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}