using Microsoft.SqlServer.Server;
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
        protected string tipo;

        public Traduccion(int codigo, string original, string traducida, string idioma, string tipo)
        {
            this.codigo = codigo; //Opcional en constructor
            nomOriginal = original;
            nomTraducida = traducida;
            rutaActual = "./../../files";
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

        public string Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string SetRutaFicheroIdioma(string tipo)
        {
            /*switch (idioma)
            {
                case "English":
                    rutaActual += "/English";
                    break;
                default:
                    break;
            }*/

            switch (tipo)
            {
                case "Ciencia":
                    rutaActual += "/Ciencia/ciencia.txt";
                    break;
                case "Literatura":
                    rutaActual += "/Literatura/literatura.txt";
                    break;
                case "Deporte":
                    rutaActual += "/Deporte/deporte.txt";
                    break;
                default:
                    break;
            }

            return rutaActual;
        }

        public string SetRutaFicheroEspanyol(string tipo)
        {
            string ruta = "./../../files";

            switch (tipo)
            {
                case "Ciencia":
                    ruta += "/Spanish/Ciencia/ciencia.txt";
                    break;
                case "Literatura":
                    ruta += "/Spanish/Literatura/literatura.txt";
                    break;
                case "Deporte":
                    ruta += "/Spanish/Deporte/deporte.txt";
                    break;
                default:
                    break;
            }

            return ruta;
        }

        /*public int GetIndexIdioma()
        {
            int index = 0;

            if (Idioma == "English")
            {
                index = 0;
            }
            

            return index;
        }*/

        /*public int GetIndexTipo()
        {
            int index = 0;

            if (Tipo == "Ciencia")
            {
                index = 0;
            }
            else if(Tipo == "Literatura")
            {
                index = 1;
            }else if(Tipo == "Deporte")
            {
                index = 2;
            }

            return index;
        }*/
    }
}
