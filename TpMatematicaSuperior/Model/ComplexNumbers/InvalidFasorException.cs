using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMatematicaSuperior.Model.ComplexNumbers
{
    [Serializable()]
    public class InvalidFasorException : System.Exception
    {
        public static string message = "No es valido el Fasor ingresado. Recuerde que debe ingresar uan funcion trigoometrica sin o cos";
        public InvalidFasorException() : base(message) { }
        // public InvalidModulePartInPolarException(string message, System.Exception inner) : base(message, inner) { }
    }
}
