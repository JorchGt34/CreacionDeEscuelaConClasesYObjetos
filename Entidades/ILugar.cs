using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Una interfaz es la definición de como debe estar estructurado un objeto, es decir, el objeto que venga de esta interfaz debe de cumplir con lo que contiene la interfaz de manera obligatoria

namespace Etapa1.Entidades
{
    public interface ILugar
    {
        //En una interfaz no se define lo que una propiedad o un metodo tiene que hacer en un objeto, sino que se define que debe de tener 
        string Dirección { get; set; }

        void LimpiarLugar();
    }
}