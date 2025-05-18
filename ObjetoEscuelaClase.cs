namespace Etapa1
{
    //Esta clase contiene el UniqueId y el nombre que todas las demás clases utilizan, asi que se usan aqui y se le heredan a todas las demás clases

    //La clase puede ser abstracta ya que esto hace que no se hagan objetos de esta clase, sino que solo se hereden sus propiedades a otras clases
    public class ObjetoEscuelaClase
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        //Constructor, donde se inicializan los valores
        public ObjetoEscuelaClase() {
            UniqueId = Guid.NewGuid().ToString();
        }
        //Ya que todos los objetos tienen el metodo ToString(), este puede ser sobre-escrito para realizar algo diferente
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Unique ID: {UniqueId}";
        }
    }
}