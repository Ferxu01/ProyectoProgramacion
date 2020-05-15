using System;
using System.Collections;
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
        ArrayList listaTipos;
        ArrayList listaIdiomas;

        public ListaTraducciones()
        {
            listaTraducciones = new Dictionary<int,Traduccion>();

            //Listas sólo para cargar los desplegables
            listaTipos = new ArrayList();
            listaIdiomas = new ArrayList();
        }

        public void Add(Traduccion traduccion)
        {
            listaTraducciones.Add(traduccion.Codigo,traduccion);

            //GuardarTraducciones(traduccion.Idioma,traduccion.Tipo,traduccion);
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

        public ArrayList CargarListaTipos()
        {
            string linea;

            try
            {
                StreamReader fichero = File.OpenText(@"./../../files/types/types.txt");

                do
                {
                    linea = fichero.ReadLine();

                    if (linea != null)
                    {
                        listaTipos.Add(linea);
                    }
                } while (linea != null);

                fichero.Close();
            }
            catch (IOException)
            {
            }

            return listaTipos;
        }

        public ArrayList CargarListaIdiomas()
        {
            string linea;

            try
            {
                StreamReader fichero = File.OpenText(@"./../../files/languages/languages.txt");

                do
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                    {
                        listaIdiomas.Add(linea);
                    }
                } while (linea != null);

                fichero.Close();
            }
            catch (IOException)
            {
            }

            return listaIdiomas;
        }

        public Traduccion SeleccionarIdiomaCrear(int indexIdioma, string original, string traducida,
            int indexTipo, int codigo)
        {
            Traduccion traduccion = null;
            string tipo;

            switch (indexTipo)
            {
                case 0:
                    tipo = "Ciencia";
                    break;
                case 1:
                    tipo = "Literatura";
                    break;
                case 2:
                    tipo = "Deporte";
                    break;
                default:
                    tipo = "";
                    break;
            }

            switch (indexIdioma)
            {
                case 0:
                    traduccion = new TraduccionIngles(codigo, original, traducida, "English", tipo);
                    break;
                default:
                    break;
            }

            return traduccion;
        }

        public void GuardarTraducciones(string idioma, string tipo, Traduccion traduccion)
        {
            string ruta = traduccion.SetRutaFichero(tipo);
            
            StreamWriter fichero = File.CreateText(@ruta);

            foreach (KeyValuePair<int,Traduccion> lista in listaTraducciones)
            {
                fichero.WriteLine(lista.Key+";"+lista.Value.NomOriginal+";"+lista.Value.NomTraducida);
            }

            fichero.Close();
        }

        /*public void CargarTraducciones(string rutaFichero)
        {
            string linea;

            try
            {
                StreamReader fichero = File.OpenText(rutaFichero);

                do
                {
                    linea = fichero.ReadLine();

                    if (linea != null)
                    {
                    }


                } while (linea != null);

                fichero.Close();
            }
            catch (IOException)
            {
            }
        }*/
    }
}
