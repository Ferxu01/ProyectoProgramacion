using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTraducciones.clases
{
    public abstract class Traduccion
    {
        protected int codigo;
        protected string nomOriginal;
        protected string nomTraducida;
        protected string rutaActual;
        protected string idioma;
        protected int codigoTipo;

        public Traduccion(int codigo,string original, string traducida, string idioma, int codTipo)
        {
            this.codigo = codigo; //Atributo opcional
            nomOriginal = original;
            nomTraducida = traducida;
            rutaActual = @"./../../files";
            this.idioma = idioma;
            codigoTipo = codTipo;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public string NomOriginal
        {
            get { return nomOriginal; }
            set { nomOriginal = value; }
        }

        public string NomTraducida
        {
            get { return nomTraducida; }
            set { nomTraducida = value; }
        }

        public string RutaActual
        {
            get { return rutaActual; }
            set { rutaActual = value; }
        }

        public string Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }

        public int CodigoTipo
        {
            get { return codigoTipo; }
            set { codigoTipo = value; }
        }

    }
}
