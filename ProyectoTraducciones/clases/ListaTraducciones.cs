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

            //Esta opción hace que de error por repetirse los códigos del dictionary cuando se cargaron anteriormente
            //listaTraducciones = CargarTraducciones();

            //Listas sólo para cargar los desplegables
            listaTipos = new ArrayList();
            listaIdiomas = new ArrayList();
        }

        public void MostrarTraducciones(ListView listaEliminarTraduccion)
        {
            foreach (KeyValuePair<int,Traduccion> list in listaTraducciones)
            {
                ListViewItem columna = new ListViewItem(list.Key.ToString());
                columna.SubItems.Add(list.Value.NomOriginal);
                columna.SubItems.Add(list.Value.NomTraducida);
                listaEliminarTraduccion.Items.Add(columna);
            }
        }

        public void Add(Traduccion traduccion)
        {
            listaTraducciones.Add(traduccion.Codigo,traduccion);

            //SeleccionarFicheroGuardar(traduccion.Tipo,traduccion);

            //GuardarTraducciones(traduccion.Tipo,traduccion);
        }

        public void Borrar(int codigo)
        {
            listaTraducciones.Remove(codigo);
        }

        public void Editar(Traduccion traduccion)
        {

        }

        public void Buscar(int codigo)
        {

        }

        public Dictionary<int,Traduccion> ListaTrads
        {
            get { return listaTraducciones; }
            set { listaTraducciones = value; }
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

        public void GuardarTraducciones(string tipo, Traduccion traduccion)
        {
            string rutaEspanyol = traduccion.SetRutaFicheroEspanyol(tipo);
            string rutaIdioma = traduccion.SetRutaFicheroIdioma(tipo);
            StreamWriter ficheroEspanyol;
            StreamWriter ficheroIdioma;

            try
            {
                foreach (KeyValuePair<int, Traduccion> lista in listaTraducciones)
                {
                    ficheroEspanyol = File.CreateText(@rutaEspanyol); //Podría ponerse AppendText
                    ficheroIdioma = File.CreateText(@rutaIdioma);

                    ficheroEspanyol.WriteLine(lista.Value.NomOriginal);
                    ficheroIdioma.WriteLine(lista.Value.NomTraducida);

                    ficheroEspanyol.Close();
                    ficheroIdioma.Close();
                }
            }
            catch (IOException)
            {
            }
        }

        public StreamWriter SeleccionarFicheroGuardar(string tipo, string idioma)
        {
            StreamWriter ficheroGuardar = File.CreateText(@"./../../files/"+idioma+"/"+tipo.ToLower()+".txt");

            return ficheroGuardar;
        } //Dudando si utilizarlo

        public Dictionary<int,Traduccion> CargarTraducciones(/*string rutaFicheroEspanyol, string rutaFicheroIdioma*/)
        {
            string[] idiomas = { "English" };
            string[] tipos = { "Ciencia", "Literatura", "Deporte" };
            string rutaFicheros = "./../../files";
            Traduccion trad;
            int codigo = 0;
            string lineaEspanyol = "";
            string lineaIdioma = "";
            

            int GetIndexTipo(string tipo)
            {
                int index = 0;

                if (tipo == tipos[0])
                    index = 0;

                if (tipo == tipos[1])
                    index = 1;

                if (tipo == tipos[2])
                    index = 2;

                return index;
            }

            int GetIndexIdioma(string idioma)
            {
                int index = 0;

                if (idioma == idiomas[0])
                    index = 0;

                return index;
            }

            try
            {
                foreach (string idioma in idiomas)
                {
                    foreach (string tipo in tipos)
                    {
                        StreamReader ficheroEspanyol = File.OpenText(rutaFicheros+"/Spanish"+"/"+tipo+"/"+tipo.ToLower()+".txt");
                        StreamReader ficheroIdioma = File.OpenText(rutaFicheros+"/"+idioma+"/"+tipo+"/"+tipo.ToLower()+".txt");

                        int indexTipo = GetIndexTipo(tipo);
                        int indexIdioma = GetIndexIdioma(idioma);

                        do
                        {
                            lineaEspanyol = ficheroEspanyol.ReadLine();
                            lineaIdioma = ficheroIdioma.ReadLine();

                            if (lineaEspanyol != null || lineaIdioma != null)
                            {
                                codigo++;
                                trad = SeleccionarIdiomaCrear(indexIdioma, lineaEspanyol, lineaIdioma, indexTipo, codigo);
                                listaTraducciones.Add(codigo, trad);
                            }
                        } while (lineaEspanyol != null || lineaIdioma != null);
                        

                        ficheroEspanyol.Close();
                        ficheroIdioma.Close();
                    }
                }
            }
            catch (IOException)
            {
            }

            return listaTraducciones;

            //Hacer que el siguiente método empiece a crear objetos a partir del último código
            //return codigo;
        }
    }
}
