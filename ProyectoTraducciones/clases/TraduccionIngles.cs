using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTraducciones.clases
{
    public class TraduccionIngles : Traduccion
    {
        protected string rutaIdioma;

        public TraduccionIngles(int codigo, string original, string traducida, string idioma, int codigoTipo) 
            :base(codigo, original, traducida, idioma, codigoTipo)
        {
            rutaIdioma = "/English";
        }

        public string RutaIdioma
        {
            get { return rutaIdioma; }
        }
    }
}
