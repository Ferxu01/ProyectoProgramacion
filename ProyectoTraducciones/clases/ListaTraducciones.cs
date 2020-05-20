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

        public void Buscar(int codigo) //Método opcional para utilizar, pude hacerlo de otra forma
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

        public void GuardarTraducciones(/*Traduccion traduccion*/)
        {
            string[] idiomas = { "English" };
            string[] tipos = { "Ciencia", "Literatura", "Deporte" };
            string rutaFicheros = "./../../files";

            //string rutaEspanyol = traduccion.SetRutaFicheroEspanyol(tipo);
            //string rutaIdioma = traduccion.SetRutaFicheroIdioma(tipo);
            StreamWriter ficheroEspanyol;
            StreamWriter ficheroIdioma;

            try
            {
                foreach (KeyValuePair<int,Traduccion> lista in listaTraducciones)
                {
                    /*if (lista.Value.Idioma == "")
                    {

                    }*/

                    //Puede ponerse opcionalmente AppendText
                    ficheroEspanyol = File.AppendText(rutaFicheros+"/Spanish"+"/"+lista.Value.Tipo+"/"+lista.Value.Tipo.ToLower()+".txt");
                    
                    ficheroIdioma = File.AppendText(SeleccionarRutaGuardar(rutaFicheros,lista.Value.Idioma,lista.Value.Tipo));

                    ficheroEspanyol.WriteLine(lista.Value.NomOriginal);
                    ficheroIdioma.WriteLine(lista.Value.NomTraducida);

                    ficheroEspanyol.Close();
                    ficheroIdioma.Close();
                }
            }
            catch (IOException e)
            {
                DialogResult dialog = MessageBox.Show("Error: "+e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            string SeleccionarRutaGuardar(string rutaGeneral, string idioma, string tipo)
            {
                string rutaActual = rutaGeneral;

                switch (idioma)
                {
                    case "English":
                        rutaActual += "/English";
                        break;
                    default:
                        break;
                }

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
        }

        public Dictionary<int,Traduccion> CargarTraducciones()
        {
            string[] idiomas = { "English" };
            string[] tipos = { "Ciencia", "Literatura", "Deporte" };
            string rutaFicheros = "./../../files";
            Traduccion trad;
            int codigo = 0;
            string lineaEspanyol;
            string lineaIdioma;
            

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

        public string GetNomIdioma(int index)
        {
            string idioma = "";
            switch (index)
            {
                case 0:
                    idioma = "English";
                    break;
                default:
                    break;
            }
            return idioma;
        }

        public string GetNomTipo(int index)
        {
            string tipo = "";
            switch (index)
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
                    break;
            }
            return tipo;
        }

        public void FiltrarPorIdiomaTipo(ComboBox dropDownIdioma,ComboBox dropDownTipo,ListView lista)
        {
            int indexIdioma = dropDownIdioma.SelectedIndex;
            string idioma = GetNomIdioma(indexIdioma);
            int indexTipo = dropDownTipo.SelectedIndex;
            string tipo = GetNomTipo(indexTipo);

            if (lista != null)
            {
                if (indexIdioma != -1 || indexTipo != -1)
                {
                    lista.Items.Clear();
                    foreach (KeyValuePair<int, Traduccion> list in listaTraducciones)
                    {
                        if (idioma == list.Value.Idioma && tipo == list.Value.Tipo)
                        {
                            ListViewItem columna = new ListViewItem(list.Key.ToString());
                            columna.SubItems.Add(list.Value.NomOriginal);
                            columna.SubItems.Add(list.Value.NomTraducida);
                            lista.Items.Add(columna);
                        }
                    }
                }
            }
        }

        public void FiltrarPorNombre(KeyValuePair<int,Traduccion> list, TextBox nombreOriginalTraduccion, ListView listView)
        {
            if (list.Value.NomOriginal.ToLower().StartsWith(nombreOriginalTraduccion.Text.ToLower()))
            {
                ListViewItem columna = new ListViewItem(list.Key.ToString());
                columna.SubItems.Add(list.Value.NomOriginal);
                columna.SubItems.Add(list.Value.NomTraducida);
                listView.Items.Add(columna);
            }
        }

        public void ResetearControlesFormulario(ComboBox dropDownIdioma, ComboBox dropDownTipo)
        {
            //dropDownIdioma.SelectedIndex = 0;
            //dropDownTipo.SelectedIndex = 0;
        }
    }
}
