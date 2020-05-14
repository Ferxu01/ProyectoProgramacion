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
        protected int idioma;
        protected int tipo;

        public Traduccion(int codigo,string original, string traducida, int idioma, int tipo)
        {
            this.codigo = codigo; //Opcional en constructor
            nomOriginal = original;
            nomTraducida = traducida;
            rutaActual = @"./../../files";
            this.idioma = idioma;
            this.tipo = tipo;
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

        public int Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
