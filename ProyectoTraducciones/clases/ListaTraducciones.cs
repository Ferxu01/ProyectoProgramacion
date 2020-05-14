using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTraducciones.clases
{
    public class ListaTraducciones
    {
        Dictionary<int,Traduccion> listaTraducciones;
        Dictionary<int,string> listaCodigosTipo;
        Dictionary<int,string> listaCodigosIdioma;

        public ListaTraducciones()
        {
            listaTraducciones = new Dictionary<int,Traduccion>();
            listaCodigosTipo = new Dictionary<int,string>();
            listaCodigosIdioma = new Dictionary<int,string>();
        }

        public void Add(Traduccion traduccion)
        {
            listaTraducciones.Add(traduccion.Codigo,traduccion);
        }

        public void Borrar(int codigo)
        {

        }

        public void Editar(Traduccion traduccion)
        {

        }

        public void Buscar(int codigo)
        {

        }

        public Dictionary<int,string> CargarListaTipos()
        {
            string linea;
            string[] tiposSeparados;
            int codTipo;
            string nomTipo;

            try
            {
                StreamReader fichero = File.OpenText(@"./../../files/types/types.txt");

                do
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                    {
                        tiposSeparados = linea.Split(';');
                        codTipo = Convert.ToInt32(tiposSeparados[0]);
                        nomTipo = tiposSeparados[1];

                        listaCodigosTipo.Add(codTipo, nomTipo);
                    }
                } while (linea != null);

                fichero.Close();
            }
            catch (IOException)
            {
            }

            return listaCodigosTipo;
        }

        public Dictionary<int,string> CargarListaIdiomas()
        {
            string linea;
            string[] tiposSeparados;
            int codIdioma;
            string nomIdioma;

            try
            {
                StreamReader fichero = File.OpenText(@"./../../files/languages/languages.txt");

                do
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                    {
                        tiposSeparados = linea.Split(';');
                        codIdioma = Convert.ToInt32(tiposSeparados[0]);
                        nomIdioma = tiposSeparados[1];

                        listaCodigosIdioma.Add(codIdioma, nomIdioma);
                    }
                } while (linea != null);

                fichero.Close();
            }
            catch (IOException)
            {
            }

            return listaCodigosIdioma;
        }
    }
}
